using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizasyon
{
    class Agri
    {
        List<List<double>> distance_matrix = new List<List<double>>();
        List<string> name_city = new List<string>();
        List<int> main_solution = new List<int>();
        List<List<int>> solutions = new List<List<int>>();
        List<int> limit_solutions = new List<int>();

        int iteration;
        int food, limit;

        public Agri(List<List<double>> distance_matrix, List<string> name_city, int iteration, int food, int limit)
        {
            this.distance_matrix = distance_matrix;
            this.name_city = name_city;
            this.iteration = iteration;
            this.food = food;
            this.limit = limit;
        }

        List<int> solution_copy(List<int> sol)
        {
            List<int> a = new List<int>();
            for (int i = 0; i < sol.Count; i++)
            {
                a.Add(sol[i]);
            }
            return a;
        }

        public void find_initial_solution()
        {
            Random r = new Random();
            List<int> temp;
            int length_data = this.name_city.Count;
            int first_city_number = 0;
            int num, x;
            for (int i = 0; i < this.food; i++)
            {
                temp = new List<int>();
                while (temp.Count != (length_data + 1))
                {
                    num = r.Next(0, 100);
                    x = num % length_data;
                    if (temp.Count == 0)
                    {
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
                //this.main_solution.Add(temp);
                

                this.solutions.Add(temp);
                this.limit_solutions.Add(0);
            }

            this.main_solution = this.solution_copy(this.solutions[0]);
            selection_best_solution();
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

        public void selection_best_solution()
        {
            double val = this.evalute_solution(this.solutions[0]);
            int idx = 0;
            for (int i = 0; i < this.food; i++)
            {
                double temp_val = this.evalute_solution(this.solutions[i]);
                if (val >= temp_val)
                {
                    idx = i;
                    val = temp_val;
                }
            }

            double x = this.evalute_solution(this.solutions[idx]);
            double y = this.evalute_solution(this.main_solution);
            if (y >= x)
            {
                main_solution = solution_copy(solutions[idx]);
            }
        }

        // for local search
        List<int> mutat_path(List<int> path)
        {
            Random r = new Random();
            List<int> mut_path = this.solution_copy(path);
            int stop = path.Count - 2;
            int start = r.Next(1, stop - 2);
            for (int i = start; i < stop+1; i++)
            {
                mut_path[i] = path[stop - i + start];   
            }
            return mut_path;
        }

        public void workerBee()
        {
            for (int i = 0; i < this.food; i++)
            {
                List<int> path = solution_copy(solutions[i]);
                double score_path_1 = evalute_solution(solutions[i]);
                List<int> local_path = mutat_path(path);
                double score_path_2 = evalute_solution(local_path);

                if (score_path_1 < score_path_2)
                {
                    limit_solutions[i] += 1;
                }
                else
                {
                    limit_solutions[i] = 0;
                    solutions[i] = solution_copy(solution_copy(local_path));
                }
            }
        }

        public void lookerBee()
        {
            for (int i = 0; i < this.food; i++)
            {
                Random r = new Random();
                if (r.NextDouble() > 0.5)
                {
                    List<int> path = solution_copy(solutions[i]);
                    double score_path_1 = evalute_solution(solutions[i]);
                    List<int> local_path = mutat_path(path);
                    double score_path_2 = evalute_solution(local_path);

                    if (score_path_1 < score_path_2)
                    {
                        limit_solutions[i] += 1;
                    }
                    else
                    {
                        limit_solutions[i] = 0;
                        solutions[i] = solution_copy(solution_copy(local_path));
                    }
                }
                
            }
        }

        public void explorBee()
        {
            // ------------ for create new solution --------------
            Random r = new Random();
            
            int length_data = this.name_city.Count;
            int first_city_number = 0;
            int num, x;
            // ------------ for create new solution --------------
            // ---------------------------------------------------


            for (int i = 0; i < food; i++)
            {
                if (limit_solutions[i] >= limit)
                {
                    // --------------------------
                    List<int> temp = new List<int>();
                    while (temp.Count != (length_data + 1))
                    {
                        num = r.Next(0, 100);
                        x = num % length_data;
                        if (temp.Count == 0)
                        {
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
                    //-------------------------------
                    limit_solutions[i] = 0;
                    solutions[i] = solution_copy(temp);

                }
            }
        }

        public void search()
        {
            find_initial_solution();
            for (int i = 0; i < iteration; i++)
            {
                workerBee();
                lookerBee();
                explorBee();
                selection_best_solution();
            }
               
        }
        public int get_iteration(){
            return iteration;
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
            name.Add(this.name_city[cromsome[0]]);  // becuase last city is first city and name matrix smaller than cromosome by 1
            return name;
        }
    }
}
