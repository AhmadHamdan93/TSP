using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizasyon
{
    class Aco
    {
        List<List<double>> fermon = new List<List<double>>();
        List<List<double>> heuristic = new List<List<double>>();
        List<List<double>> distance_matrix = new List<List<double>>();
        List<string> name_city = new List<string>();
        int a_parameter ;
        int b_paramater;
        int iteration;
        int karinca;
        double p_paramater;
        double fermon_value;
        List<int> main_solution = new List<int>();

        public Aco(List<List<double>> distance_matrix, List<string> name, int iteration,
            int a_paramater,int b_paramater,double p_paramater,double fermon_val,int karinca_num)
        {
            this.distance_matrix = distance_matrix;
            this.name_city = name;
            //  
            
            this.a_parameter = a_paramater;
            this.b_paramater = b_paramater;
            this.p_paramater = p_paramater;
            this.iteration = iteration;
            this.karinca = karinca_num;
            this.fermon_value = fermon_val;
            //
            this.fermon = this.generate_fermon();
            this.heuristic = this.generate_heuristic();
        }
        List<List<double>> generate_fermon()
        {
            int length = this.name_city.Count;
            List<List<double>> temp_fermon = new List<List<double>>();
            for (int i = 0; i < length; i++)
            {
                List<double> temp = new List<double>();
                for (int j = 0; j < length; j++)
                {
                    temp.Add(this.fermon_value);
                }
                temp_fermon.Add(temp);
            }
            return temp_fermon;
        }
        public void solution_generate()
        {
            Random r = new Random();
            List<List<int>> karinca_solution = new List<List<int>>();
            for (int ant = 0; ant < this.karinca; ant++)
            {
                List<int> one_solution = new List<int>();
                List<List<double>> heuristic_local = this.heuristic_copy();
                // ------------------ for first city ---------------
                int first_city = r.Next(0, this.name_city.Count);
                one_solution.Add(first_city);
                heuristic_local = this.heuristic_edit(first_city, heuristic_local);
                // -------------------- for other city --------------
                for (int count = 0; count < this.name_city.Count - 1; count++)
                {
                    int next_city = this.find_next_city_probability(one_solution, heuristic_local);
                    one_solution.Add(next_city);
                    heuristic_local = this.heuristic_edit(next_city, heuristic_local);
                }
                one_solution.Add(one_solution[0]);
                karinca_solution.Add(one_solution);
            }
            // --------------- for selection one solution from all ---------
            // --- in this part must evalute all of solution then one solution selecting --------
            List<double> evalute_karinca_solution = new List<double>();
            for (int i = 0; i < karinca_solution.Count; i++)
            {
                evalute_karinca_solution.Add(this.evalute_solution(karinca_solution[i]));
            }
            double min_value = evalute_karinca_solution[0];
            int min_index = 0;
            for (int idx = 0; idx < this.karinca; idx++)
            {
                if (min_value >= evalute_karinca_solution[idx])
                {
                    min_value = evalute_karinca_solution[idx];
                    min_index = idx;
                }
            }

            if (this.main_solution.Count > 0)
            {
                if (this.evalute_solution(this.main_solution) >= min_value)
                {
                    this.main_solution.Clear();
                    this.main_solution = this.copy_solution(karinca_solution[min_index]);
                }
            }
            else
            {
                this.main_solution.Clear();
                this.main_solution = this.copy_solution(karinca_solution[min_index]);
            }
            // ------------------------ end selection ------------------------
        }
        List<int> copy_solution(List<int> sol)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < sol.Count; i++)
            {
                temp.Add(sol[i]);
            }
            return temp;
        }
        List<List<double>> generate_heuristic()
        {
            int length = this.distance_matrix.Count;
            List<List<double>> temp_heuristic = new List<List<double>>();
            for (int i = 0; i < length; i++)
            {
                List<double> temp = new List<double>();
                for (int j = 0; j < length; j++)
                {
                    if (this.distance_matrix[i][j] == 0)
                    {
                        temp.Add(0.0);
                    }
                    else
                    {
                        double f = 1.0 / distance_matrix[i][j];
                        f = Math.Round(f, 5);
                        temp.Add(f);
                    }
                }
                temp_heuristic.Add(temp);
            }
            return temp_heuristic;
        }
        public double evalute_solution(List<int> cromo)
        {
            double gene_sum = 0;
            int m, n;
            for (int i = 0; i < cromo.Count - 1; i++)
            {
                m = cromo[i];
                n = cromo[i + 1];
                gene_sum = gene_sum + this.distance_matrix[m][n];
            }
            return gene_sum;
        }
        int find_next_city_probability(List<int> one_solution, List<List<double>> heuristic_local)
        {
            // --------------- for formulle ---------------
            int number_of_city = this.name_city.Count;
            List<int> rest_city = new List<int>();
            int current_city = one_solution[one_solution.Count - 1];
            // --------------------------
            double sum_fermon_heuristic = 0.0;
            List<double> fermon_heuristic = new List<double>();
            List<double> city_probability = new List<double>();
            // ------------------------------
            for (int i = 0; i < number_of_city; i++)
            {
                if (one_solution.IndexOf(i) < 0)
                {
                    rest_city.Add(i);
                }
            }
            for (int idx = 0; idx < rest_city.Count; idx++)
            {
                double x = Math.Pow(this.fermon[current_city][rest_city[idx]], this.a_parameter) * Math.Pow(heuristic_local[current_city][rest_city[idx]], this.b_paramater);
                x = Math.Round(x, 8);
                fermon_heuristic.Add(x);
                sum_fermon_heuristic += x;
            }

            for (int i = 0; i < fermon_heuristic.Count; i++)
            {
                double x = fermon_heuristic[i] * 1.0 / sum_fermon_heuristic;
                x = Math.Round(x, 5);
                city_probability.Add(x);
            }
            // -------------- find index max ------------
            double max_value = city_probability[0];
            int max_index = 0;
            for (int idx = 0; idx < city_probability.Count; idx++)
            {
                if (max_value < city_probability[idx])
                {
                    max_value = city_probability[idx];
                    max_index = idx;
                }
            }
            return rest_city[max_index];
        }
        List<List<double>> heuristic_copy()
        {
            List<List<double>> temp_heuristic = new List<List<double>>();
            for (int i = 0; i < this.heuristic.Count; i++)
            {
                List<double> temp = new List<double>();
                for (int j = 0; j < this.heuristic.Count; j++)
                {
                    temp.Add(this.heuristic[i][j]);
                }
                temp_heuristic.Add(temp);
            }
            return temp_heuristic;
        }
        List<List<double>> heuristic_edit(int column, List<List<double>> heuristic_matrix)
        {
            List<List<double>> temp_heuristic = new List<List<double>>();
            for (int i = 0; i < heuristic_matrix.Count; i++)
            {
                List<double> temp = new List<double>();
                for (int j = 0; j < heuristic_matrix.Count; j++)
                {
                    if (j == column)
                    {
                        temp.Add(0.0);
                    }
                    else
                    {
                        temp.Add(heuristic_matrix[i][j]);
                    }
                }
                temp_heuristic.Add(temp);
            }
            return temp_heuristic;
        }
        public void fermon_update()
        {
            double f = 1 - this.p_paramater;
            double L = this.evalute_solution(this.main_solution);
            double delta_f = 1.0 / L;
            int length = this.name_city.Count;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    this.fermon[i][j] = f * this.fermon[i][j];
                }
                
            }
            for (int i = 0; i < length; i++)
            {
                int i1 = this.main_solution[i];
                int j1 = this.main_solution[i + 1];
                this.fermon[i1][j1] = delta_f + this.fermon[i1][j1];
                this.fermon[j1][i1] = delta_f + this.fermon[j1][i1];
            }
            
        }
        
        public List<int> get_solution()
        {
            return this.main_solution;
        }
        public List<string> get_name_cromosome(List<int> cromsome)
        {
            List<string> name = new List<string>();
            for (int i = 0; i < cromsome.Count - 1; i++)
            {
                name.Add(this.name_city[cromsome[i]]);
            }
            name.Add(this.name_city[cromsome[0]]); 
            return name;
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
