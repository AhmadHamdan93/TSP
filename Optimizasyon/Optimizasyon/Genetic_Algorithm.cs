using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizasyon
{
    class GeneticAlgorithm
    {
        List<string> name_citys = new List<string>();                   // for save name of city 
        List<int> lucky_matrix = new List<int>();                       // for chose city by roulette wheel
        List<List<int>> distance = new List<List<int>>();               // for save distance between citys
        List<List<int>> all_solution = new List<List<int>>();           // for 14 solution
        List<List<int>> main_solution = new List<List<int>>();          // for 5 solution
        int iteration;                                                  // stop condition

        public GeneticAlgorithm(List<List<int>> distance_matrix, List<string> name, int itera)
        {
            this.distance = distance_matrix;
            this.name_citys = name;
            this.iteration = itera;
        }
        public void find_initial_solution()
        {
            Random r = new Random();
            List<int> temp;
            int length_data = this.name_citys.Count;
            int first_city_number = 0;
            int num, x;
            for (int i = 0; i < 5; i++)
            {
                temp = new List<int>();
                while (temp.Count != (length_data + 1))
                {
                    num = r.Next(0, 100);
                    x = num % length_data;
                    if (temp.Count == 0){
                        first_city_number = x;
                    }
                    if (temp.IndexOf(x) < 0)
                    {
                        temp.Add(x);
                    }
                    if (temp.Count == length_data)
                    {
                        temp.Add(first_city_number);
                    }
                }
                this.main_solution.Add(temp);
                this.all_solution.Add(temp);
            }
            // --------------- for generate new luck matrix ----------------
            this.generate_lucky_matrix();
            // --------------------------------------

        }
        public List<string> get_name_cromosome(List<int> cromsome)
        {
            List<string> name = new List<string>();
            for (int i = 0; i < cromsome.Count - 1; i++)
            {
                name.Add(this.name_citys[cromsome[i]]);
            }
            name.Add(this.name_citys[cromsome[0]]);  // becuase last city is first city and name matrix smaller than cromosome by 1
            return name;
        }
        public void crossover()
        {
            Random r = new Random();
            int idx1, idx2, crossover_point;
            for (int c = 0; c < 4; c++)
            {
                idx1 = this.find_luck_solution();
                idx2 = this.find_luck_solution();
                while (idx1 == idx2)
                {
                    idx2 = this.find_luck_solution();
                }
                crossover_point = r.Next(1, this.name_citys.Count);
                this.cross(idx1,idx2,crossover_point);
            }
        }
        void cross(int id1, int id2, int point)
        {
            List<int> cromosome_1 = new List<int>();
            List<int> cromosome_2 = new List<int>();
            List<int> new_cromosome_1 = new List<int>();
            List<int> new_cromosome_2 = new List<int>();
            cromosome_1 = this.cromosome_copy(this.main_solution[id1]);
            cromosome_2 = this.cromosome_copy(this.main_solution[id2]);
            new_cromosome_1 = this.cromsome_init();
            new_cromosome_2 = this.cromsome_init();
            int length_crom = cromosome_1.Count;

            for (int i = point; i < length_crom; i++)
            {
                new_cromosome_1[i] = cromosome_2[i];
                new_cromosome_2[i] = cromosome_1[i];
            }
            new_cromosome_1[0] = new_cromosome_1[length_crom - 1];
            new_cromosome_2[0] = new_cromosome_2[length_crom - 1];
            for (int idx = 0; idx < length_crom; idx++)
            {
                if (new_cromosome_1.IndexOf(cromosome_1[idx]) < 0)
                {
                    int m = this.int_for_insert_gene(new_cromosome_1);
                    if (m != -1)
                    {
                        new_cromosome_1[m] = cromosome_1[idx];
                    }
                }
            }
            for (int idx = 0; idx < length_crom; idx++)
            {
                if (new_cromosome_2.IndexOf(cromosome_2[idx]) < 0)
                {
                    int m = this.int_for_insert_gene(new_cromosome_2);
                    if (m != -1)
                    {
                        new_cromosome_2[m] = cromosome_2[idx];
                    }
                }
            }
            this.all_solution.Add(new_cromosome_1);
            this.all_solution.Add(new_cromosome_2);
        }
        int int_for_insert_gene(List<int> gene)
        {
            for (int i = 0; i < gene.Count; i++)
            {
                if (gene[i] == -1)
                {
                    return i;
                }
            }
            return -1;
        }
        List<int> cromosome_copy(List<int> cromosome)
        {
            List<int> a = new List<int>();
            for (int i = 0; i < cromosome.Count; i++)
            {
                a.Add(cromosome[i]);
            }
                return a;
        }
        List<int> cromsome_init()
        {
            List<int> a = new List<int>();
            for (int i = 0; i < this.name_citys.Count + 1; i++)
            {
                a.Add(-1);
            }
                return a;
        }
        public void mutation()
        {
            Random r = new Random();
            List<int> cromosome = new List<int>();
            List<int> new_cromosome = new List<int>();
            int idx = this.find_luck_solution();
            cromosome = this.cromosome_copy(this.main_solution[idx]);
            new_cromosome = this.cromosome_copy(this.main_solution[idx]);
            int point1 = r.Next(0, this.name_citys.Count);
            int point2 = r.Next(0, this.name_citys.Count);
            while (point1 == point2)
            {
                point2 = r.Next(0, this.name_citys.Count);
            }
            if (point1 > point2)
            {
                int temp = point1;
                point1 = point2;
                point2 = temp;
            }
            for (int i = 0; i < cromosome.Count; i++)
            {
                if (( i < point1 ) || ( i > point2 )){
                    new_cromosome[i] = cromosome[i];
                }
                else
                {
                    new_cromosome[i] = cromosome[point2 - i + point1];
                }
            }
            if (point1 == 0)
            {
                new_cromosome[cromosome.Count - 1] = new_cromosome[0];
            }
            if (point2 == cromosome.Count - 1)
            {
                new_cromosome[0] = new_cromosome[cromosome.Count - 1];
            }
            this.all_solution.Add(new_cromosome);
        }
        public void selection()
        {
            List<int> all_evalute_matrix = new List<int>();
            int x = 0,num1;
            List<int> temp;
            for (int i = 0; i < this.all_solution.Count; i++)
            {
                x = this.evalute_solution(this.all_solution[i]);
                all_evalute_matrix.Add(x);
            }

            for (int i = 0; i < all_evalute_matrix.Count; i++)
            {
                for (int j = 0; j < all_evalute_matrix.Count - i -1; j++)
                {
                    if (all_evalute_matrix[j] > all_evalute_matrix[j + 1])
                    {
                        num1 = all_evalute_matrix[j];
                        all_evalute_matrix[j] = all_evalute_matrix[j + 1];
                        all_evalute_matrix[j + 1] = num1;
                        // change solution
                        temp = this.all_solution[j];
                        this.all_solution[j] = this.all_solution[j + 1];
                        this.all_solution[j + 1] = temp;

                    }
                }
            }
            this.main_solution.Clear();
            for (int i = 0; i < 5; i++)
            {
                this.main_solution.Add(this.all_solution[i]);
            }
            this.all_solution.Clear();
            for (int i = 0; i < 5; i++)
            {
                this.all_solution.Add(this.main_solution[i]);
            }
            // --------------- for generate new luck matrix ----------------
            this.generate_lucky_matrix();
            // --------------------------------------
        }
        public int evalute_solution(List<int> cromo)
        {
            int gene_sum = 0 ,m,n;
            for (int i = 0; i < cromo.Count - 1; i++)
            {
                m = cromo[i];
                n = cromo[i + 1];
                gene_sum = gene_sum + this.distance[m][n];
            }
            return gene_sum;
        }
        int find_luck_solution()
        {
            Random r = new Random();
            int num_rand = r.Next(0, 360);
            int index = this.lucky_matrix.Count - 1;
            for (int i = 0; i < this.lucky_matrix.Count; i++)
            {
                if (num_rand <= this.lucky_matrix[i])
                {
                    return i;
                }
            }
            return index;
        }
        void generate_lucky_matrix()
        {
            
            this.lucky_matrix.Clear();
            List<int> evalute_matrix = new List<int>();
            List<double> invers_evaluting = new List<double>();
            double invers_eval_sum = 0.0;
            List<int> cornar_grade = new List<int>();
            int cornar_sum = 0;
            for (int i = 0; i < this.main_solution.Count; i++)
            {
                int evalute = this.evalute_solution(this.main_solution[i]);
                evalute_matrix.Add(evalute);
                double invers_eval = 1.0 / evalute;
                invers_eval = Math.Round(invers_eval, 5);
                invers_evaluting.Add(invers_eval);
                invers_eval_sum += invers_eval;
            }
            for (int i = 0; i < invers_evaluting.Count; i++)
            {
                int cornar = (int) Math.Round(((360.0 * invers_evaluting[i]) / invers_eval_sum), 0);
                cornar_grade.Add(cornar);
                cornar_sum += cornar;
                this.lucky_matrix.Add(cornar_sum);
            }
            this.lucky_matrix[this.lucky_matrix.Count - 1] = 360;
        }
        
        public List<int> get_solution()
        {
            return this.main_solution[0];
        }
        public int get_iteration()
        {
            return this.iteration;
        }
        public string name_solution_Decode()
        {
            string name = "";
            List<string> city = this.get_name_cromosome(this.get_solution());
            for (int count = 0; count < city.Count; count++)
            {
                name += city[count];
                if (count < city.Count - 1)
                {
                    name += " - ";
                }
            }
            return name;
        }
    }
}
