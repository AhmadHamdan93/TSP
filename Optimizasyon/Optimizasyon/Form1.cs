using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Threading;
using System.Drawing.Drawing2D;



namespace Optimizasyon
{
    public partial class Form1 : Form
    {
        int x_step = 0;
        int y_step = 0;
        int x_max = 0;
        int y_max = 0;
        List<string> name = new List<string>();
        List<List<double>> distance = new List<List<double>>();
        List<List<int>> dicarte_matrix = new List<List<int>>();

        void generate_distance_matrix()
        {
            for (int i = 0; i < dicarte_matrix.Count; i++)
            {
                List<double> temp = new List<double>();
                for (int j = 0; j < dicarte_matrix.Count; j++)
                {
                    double x = dicarte_matrix[i][0] - dicarte_matrix[j][0];
                    double y = dicarte_matrix[i][1] - dicarte_matrix[j][1];
                    x = Math.Pow(x, 2);
                    y = Math.Pow(y, 2);
                    double sqr = Math.Sqrt(x + y);
                    sqr = Math.Round(sqr, 2);
                    temp.Add(sqr);
                }
                distance.Add(temp);
            }
        }
        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [sheet1$]", con); //here we read data from sheet1  //  Sayfa1 // Sheet1$
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch { }
            }
            return dtexcel;
        }
        void read_data_table(DataTable dt)
        {
            // -------------- for repeat data enter ---------------
            name.Clear();
            distance.Clear();
            dicarte_matrix.Clear();
            //----------------------------

            dt.Rows.RemoveAt(0);                // becuase 1. row is empty
            dt.Columns[0].ColumnName = " ";     // for change name of column
            int row_number = dt.Rows.Count;
            int column_number = dt.Columns.Count;
            dt.Columns[1].ColumnName = "X";
            dt.Columns[2].ColumnName = "Y";
            for (int i = 1; i < row_number + 1; i++)
            {
                name.Add(dt.Rows[i - 1][0].ToString());
            }
            for (int i = 0; i < row_number; i++)
            {
                List<int> temp_row = new List<int>();
                for (int j = 1; j < column_number ; j++)
                {
                    temp_row.Add(Int32.Parse(dt.Rows[i][j].ToString()));
                }
                //distance.Add(temp_row);
                dicarte_matrix.Add(temp_row);
            }
            generate_distance_matrix();
            row_label.Text = row_number.ToString();
            column_label.Text = column_number.ToString();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                masar.Text = Path.GetFileName(filePath); //find_namefile(filePath);

                fileExt = Path.GetExtension(filePath); //get the file extension  
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = ReadExcel(filePath, fileExt); //read excel file  
                        dataGridView1.Visible = true;
                        //dtExcel.Columns[1].ColumnName = "A";
                        // -----------------------------
                        //dtExcel.Rows.RemoveAt(0);
                        read_data_table(dtExcel);
                        // -------------------------
                        dataGridView1.DataSource = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //to close the window(Form1)  
        }

        public Form1()
        {
            InitializeComponent();
        }

        void draw()
        {
            // ---------------
            pictureBox1.Image = null;
            pictureBox1.Update();
            pictureBox1.Refresh();
            // -------------------------

            Graphics g = pictureBox1.CreateGraphics();


            int wid = pictureBox1.Width;
            int high = pictureBox1.Height;
            find_steps();
            // draw xox' 
            Pen pen_x = new Pen(Color.Blue);
            pen_x.EndCap = LineCap.ArrowAnchor;
            Point p1_x = new Point(10,  high - 10);
            Point p2_x = new Point(wid - 10, high - 10);
            g.DrawLine(pen_x, p1_x, p2_x);
            for (int i = 0; i < x_max + 1; i++)
            {
                x_step_draw(i, 0, g);
            }
            //------------
            // draw yoy'
            Pen pen_y = new Pen(Color.Blue);
            pen_y.EndCap = LineCap.ArrowAnchor;
            Point p1_y = new Point(10, high - 10);
            Point p2_y = new Point(10, 10);
            g.DrawLine(pen_y, p1_y, p2_y);
            for (int j = 0; j < y_max +1; j++)
            {
                y_step_draw(0, j, g);
                
            }
            //pen_y.DashStyle = DashStyle.DashDotDot;
            //g.DrawLine(pen_y, 50, 50, 100, 100);
                // -------------

                // ------ draw points of solutions ------------

            for (int i = 0; i < dicarte_matrix.Count; i++)
            {
                drawPoint(dicarte_matrix[i][0], dicarte_matrix[i][1], g, i);
            }
            

        }

        void x_step_draw(int x, int y, Graphics g)
        {
            int high = pictureBox1.Height;

            int new_x = 10 + x_step * x ;           
            int new_y = high - 10 - (y_step * y);   

            

            Color color = Color.Blue;
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, new_x, new_y, 3, 3);
            // ---------------------
            Font myFont = new Font("Arial", 7);
            SolidBrush brush1 = new SolidBrush(Color.Blue);
            if (x != 0)
            {
                g.DrawString("" + x, myFont, brush1, new_x - 2, new_y - 10);
            }
            
        }
        void y_step_draw(int x, int y, Graphics g)
        {
            int high = pictureBox1.Height;

            int new_x = 10 + x_step * x;
            int new_y = high - 10 - (y_step * y);

            Color color = Color.Blue;
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, new_x, new_y, 3, 3);
            // ---------------------
            Font myFont = new Font("Arial", 7);
            SolidBrush brush1 = new SolidBrush(Color.Blue);
            if (y != 0)
            {
                g.DrawString("" + y, myFont, brush1, new_x - 10, new_y - 5);
            }
            
        }
        void drawPoint(int x, int y, Graphics g, int idx_point)
        {
            //int wid = pictureBox1.Width;
            int high = pictureBox1.Height;

            int new_x = 10 + x_step * x - 3;          // -3 for exacut point in center because think 7
            int new_y = high - 10 - (y_step * y) - 3; // -3 for exacut point in center because think 7

            //Pen p = new Pen(Color.Red, 2);

            Color color =  Color.Red;
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, new_x, new_y, 7, 7);
            // ----------- put caption for points --------
            Font myFont = new Font("Arial", 9);
            SolidBrush brush1 = new SolidBrush(Color.Green);

            g.DrawString(name[idx_point], myFont, brush1, new_x - 15, new_y - 15);
            
        }
        void find_steps()
        {
            int wid = pictureBox1.Width;
            int high = pictureBox1.Height;

            x_max = dicarte_matrix[0][0];
            y_max = dicarte_matrix[0][1];
            for (int i = 0; i < dicarte_matrix.Count; i++)
            {
                if (x_max < dicarte_matrix[i][0])
                {
                    x_max = dicarte_matrix[i][0];
                }
                if (y_max < dicarte_matrix[i][1])
                {
                    y_max = dicarte_matrix[i][1];
                }
            }
            x_step = (wid - 20) / (x_max + 1);
            y_step = (high - 20) / (y_max + 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_aco.Checked)
            {
                int iter = Int32.Parse(aco_iteration.Value.ToString());
                int a = Int32.Parse(alpha_text.Text);
                int b = Int32.Parse(beta_text.Text);
                double p = Double.Parse(roh_text.Text);
                double fer_val = Double.Parse(fermon_value.Value.ToString());
                int karinca = Int32.Parse(aco_karinca.Value.ToString());

                //AcoAlgorithm aco = new AcoAlgorithm(distance, name, iter, a, b, p, fer_val, karinca);
                // ---------------------------------- distance / dicarte_matrix -----------
                //aco_process(aco);

                Aco aco = new Aco(distance, name, iter, a, b, p, fer_val, karinca);
                aco_process_1(aco);

            }
            else if(radio_genetic.Checked)
            {
                int iter = Int32.Parse(genetic_iteration.Value.ToString());

                int pop = Int32.Parse(pop_txt.Text.ToString());
                double mut = Int32.Parse(mut_txt.Text.ToString());
                double cross = Int32.Parse(cross_txt.Text.ToString());
                int mut1 = (int) Math.Ceiling(pop * (mut / 100.0));
                int cross1 = (int) Math.Ceiling(pop * 2 * (cross / 100.0));

                Genetic ga = new Genetic(distance, name, iter, pop, cross1, mut1);
                genetic_process_1(ga);
            }
            else
            {
                int iter = Int32.Parse(agri_iteration_txt.Text.ToString());
                int food = Int32.Parse(food_txt.Text.ToString());
                int limit = Int32.Parse(limit_txt.Text.ToString());

                Agri agri = new Agri(distance, name, iter, food, limit);
                
                BeeProcess1(agri);
            }


        }
        void BeeProcess1(Agri agri)
        {
            draw();
            //--------- for progressbar ------------------
            double percint_data = 100.0 / agri.get_iteration();
            percint_data = Math.Round(percint_data, 2);
            double percint_sum = 0.0;

            progressBar1.Maximum = agri.get_iteration();
            progressBar1.Value = 0;
            //-----------------------------------------

            agri.find_initial_solution();             // ---- first step in algorithm ------

            for (int i = 0; i < agri.get_iteration(); i++)
            {



                //---------------- thread for do in background -------------------

                // blok of main code
                agri.workerBee();
                agri.lookerBee();
                agri.explorBee();
                agri.selection_best_solution();
                //-----------------




                progressBar1.Value += 1;



                // ---------------------------------------
                // ------------ show in screen ------------

                List<int> result = agri.get_solution();
                solution_evalute.Text = agri.evalute_solution(result).ToString();
                solution_name.Text = agri.name_solution_Decode();

                draw();
                draw_lines_between_points(result); // draw

                percint_sum += percint_data;
                percint_sum = Math.Round(percint_sum, 2);
                percint.Text = percint_sum.ToString() + '%';


                Thread.Sleep(150);  // --- slow draw in screen --------- 
                // ---------------------------------------
                // ---- sometimes events in screen don't showed , because of must write this statment 
                Application.DoEvents();
                // ----------------------------------


            }
            percint.Text = "100%";
        }
        void genetic_process(GeneticAlgorithm ga)
        {
            //--------- for progressbar ------------------
            double percint_data = 100.0 / ga.get_iteration();
            percint_data = Math.Round(percint_data, 2);
            double percint_sum = 0.0;
            
            progressBar1.Maximum = ga.get_iteration();
            progressBar1.Value = 0;
            //-----------------------------------------
            
            ga.find_initial_solution();             // ---- first step in algorithm ------
           
            for (int i = 0; i < ga.get_iteration(); i++)
            {
                //---------------- thread for do in background -------------------
                
                    // blok of main code
                    ga.crossover();
                    ga.mutation();
                    ga.selection();
                    //-----------------
                    
                    Thread.Sleep(150);  // --- slow draw in screen --------- 
                

                progressBar1.Value += 1;

                

                // ---------------------------------------
                // ------------ show in screen ------------

                List<int> result = ga.get_solution();
                solution_evalute.Text = ga.evalute_solution(result).ToString();
                solution_name.Text = ga.name_solution_Decode();

                

                percint_sum += percint_data;
                percint_sum = Math.Round(percint_sum, 2);
                percint.Text = percint_sum.ToString()+'%';
                // ---------------------------------------
                // ---- sometimes events in screen don't showed , because of must write this statment 
                Application.DoEvents();
                // ----------------------------------


            }
            percint.Text = "100%";
        }
        void draw_lines_between_points(List<int> solution)
        {
            Graphics g = pictureBox1.CreateGraphics();
            int high = pictureBox1.Height;
            List<Point> sol = new List<Point>();
            Point[] points = new Point[solution.Count];
            int x, y;

            for (int i = 0; i < solution.Count; i++)
            {
                int idx = solution[i];
                x = dicarte_matrix[idx][0];
                y = dicarte_matrix[idx][1];
                int new_x = 10 + x_step * x;
                int new_y = high - 10 - (y_step * y);
                //Point p1 = new Point(new_x, new_y);
                //sol.Add(p1);
                points[i] = new Point(new_x, new_y);
            }
            

            Pen mypen = new Pen(Color.Black,2);
            g.DrawLines(mypen,points);

        }
        void genetic_process_1(Genetic ga)
        {
            
            draw();
            //--------- for progressbar ------------------
            double percint_data = 100.0 / ga.get_iteration();
            percint_data = Math.Round(percint_data, 2);
            double percint_sum = 0.0;

            progressBar1.Maximum = ga.get_iteration();
            progressBar1.Value = 0;
            //-----------------------------------------

            ga.find_initial_solution();             // ---- first step in algorithm ------

            for (int i = 0; i < ga.get_iteration(); i++)
            {

                
                
                //---------------- thread for do in background -------------------

                // blok of main code
                ga.crossover();
                ga.mutation();
                ga.selection();
                //-----------------

               


                progressBar1.Value += 1;



                // ---------------------------------------
                // ------------ show in screen ------------

                List<int> result = ga.get_solution();
                solution_evalute.Text = ga.evalute_solution(result).ToString();
                solution_name.Text = ga.name_solution_Decode();
                
                draw();
                draw_lines_between_points(result); // draw

                percint_sum += percint_data;
                percint_sum = Math.Round(percint_sum, 2);
                percint.Text = percint_sum.ToString() + '%';


                //Thread.Sleep(150);  // --- slow draw in screen --------- 
                // ---------------------------------------
                // ---- sometimes events in screen don't showed , because of must write this statment 
                Application.DoEvents();
                // ----------------------------------


            }
            percint.Text = "100%";
        }
        void aco_process(AcoAlgorithm aco)
        {

            //--------- for progressbar ------------------
            double percint_data = 100.0 / aco.get_iteration();
            percint_data = Math.Round(percint_data, 2);
            double percint_sum = 0.0;

            progressBar1.Maximum = aco.get_iteration();
            progressBar1.Value = 0;
            //-----------------------------------------

            for (int i = 0; i < aco.get_iteration(); i++)
            {
                //---------------- thread for do in background -------------------
                
                    // blok of main code
                    aco.solution_generate();
                    aco.fermon_update();
                    //-----------------

                    Thread.Sleep(150);  // --- slow draw in screen --------- 
                

                progressBar1.Value += 1;

                    

                // ---------------------------------------
                // ------------ show in screen ------------
                solution_evalute.Text = aco.evalute_solution(aco.get_solution()).ToString();
                solution_name.Text = aco.name_solution_Decode();


                percint_sum += percint_data;
                percint_sum = Math.Round(percint_sum, 2);
                percint.Text = percint_sum.ToString() + '%';
                // ---------------------------------------
                // ---- sometimes events in screen don't showed , because of must write this statment 
                Application.DoEvents();
                // ----------------------------------
            }
            percint.Text = "100%";
        }

        void aco_process_1(Aco aco)
        {
            
            draw();

            //--------- for progressbar ------------------
            double percint_data = 100.0 / aco.get_iteration();
            percint_data = Math.Round(percint_data, 2);
            double percint_sum = 0.0;

            progressBar1.Maximum = aco.get_iteration();
            progressBar1.Value = 0;
            //-----------------------------------------

            for (int i = 0; i < aco.get_iteration(); i++)
            {
                //---------------- thread for do in background -------------------
                

                // blok of main code
                aco.solution_generate();
                aco.fermon_update();
                //-----------------

               


                progressBar1.Value += 1;



                // ---------------------------------------
                // ------------ show in screen ------------
                List<int> result = aco.get_solution();
                solution_evalute.Text = aco.evalute_solution(result).ToString();
                solution_name.Text = aco.name_solution_Decode();

                draw();
                draw_lines_between_points(result); // draw

                percint_sum += percint_data;
                percint_sum = Math.Round(percint_sum, 2);
                percint.Text = percint_sum.ToString() + '%';


                Thread.Sleep(150);  // --- slow draw in screen --------- 

                // ---------------------------------------
                // ---- sometimes events in screen don't showed , because of must write this statment 
                Application.DoEvents();
                // ----------------------------------
            }
            percint.Text = "100%";
        }

        private void radio_aco_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_aco.Checked)
            {
                genetic_panel.Visible = false;
                aco_panel.Visible = true;
                agri_panel.Visible = false;
            }
        }

        private void radio_genetic_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_genetic.Checked)
            {
                genetic_panel.Visible = true;
                aco_panel.Visible = false;
                agri_panel.Visible = false;
            }
        }

        private void Load_Data_Click(object sender, EventArgs e)
        {
            btnChooseFile_Click(sender, e);
            draw();
        }

        private void agri_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (agri_radio.Checked)
            {
                genetic_panel.Visible = false;
                aco_panel.Visible = false;
                agri_panel.Visible = true;
            }
        }
    }
}
