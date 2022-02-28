namespace Optimizasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.column_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.row_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Load_Data = new System.Windows.Forms.Button();
            this.masar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aco_panel = new System.Windows.Forms.Panel();
            this.fermon_value = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roh_text = new System.Windows.Forms.TextBox();
            this.beta_text = new System.Windows.Forms.TextBox();
            this.alpha_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aco_karinca = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.aco_iteration = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.genetic_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.genetic_iteration = new System.Windows.Forms.NumericUpDown();
            this.radio_aco = new System.Windows.Forms.RadioButton();
            this.radio_genetic = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.solution_name = new System.Windows.Forms.Label();
            this.solution_evalute = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.percint = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.agri_radio = new System.Windows.Forms.RadioButton();
            this.agri_panel = new System.Windows.Forms.Panel();
            this.food_txt = new System.Windows.Forms.TextBox();
            this.limit_txt = new System.Windows.Forms.TextBox();
            this.agri_iteration_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mut_txt = new System.Windows.Forms.TextBox();
            this.cross_txt = new System.Windows.Forms.TextBox();
            this.pop_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.aco_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fermon_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aco_karinca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aco_iteration)).BeginInit();
            this.genetic_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genetic_iteration)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.agri_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(360, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.column_label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.row_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Load_Data);
            this.groupBox1.Controls.Add(this.masar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load Data";
            // 
            // column_label
            // 
            this.column_label.AutoSize = true;
            this.column_label.Location = new System.Drawing.Point(237, 262);
            this.column_label.Name = "column_label";
            this.column_label.Size = new System.Drawing.Size(13, 13);
            this.column_label.TabIndex = 6;
            this.column_label.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Column :";
            // 
            // row_label
            // 
            this.row_label.AutoSize = true;
            this.row_label.Location = new System.Drawing.Point(61, 262);
            this.row_label.Name = "row_label";
            this.row_label.Size = new System.Drawing.Size(13, 13);
            this.row_label.TabIndex = 4;
            this.row_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Row :";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(324, 204);
            this.dataGridView1.TabIndex = 2;
            // 
            // Load_Data
            // 
            this.Load_Data.Location = new System.Drawing.Point(255, 11);
            this.Load_Data.Name = "Load_Data";
            this.Load_Data.Size = new System.Drawing.Size(75, 23);
            this.Load_Data.TabIndex = 0;
            this.Load_Data.Text = "Load Data";
            this.Load_Data.UseVisualStyleBackColor = true;
            this.Load_Data.Click += new System.EventHandler(this.Load_Data_Click);
            // 
            // masar
            // 
            this.masar.AutoSize = true;
            this.masar.Location = new System.Drawing.Point(11, 21);
            this.masar.Name = "masar";
            this.masar.Size = new System.Drawing.Size(13, 13);
            this.masar.TabIndex = 0;
            this.masar.Text = "--";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.genetic_panel);
            this.groupBox2.Controls.Add(this.agri_panel);
            this.groupBox2.Controls.Add(this.agri_radio);
            this.groupBox2.Controls.Add(this.aco_panel);
            this.groupBox2.Controls.Add(this.radio_aco);
            this.groupBox2.Controls.Add(this.radio_genetic);
            this.groupBox2.Location = new System.Drawing.Point(360, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm";
            // 
            // aco_panel
            // 
            this.aco_panel.Controls.Add(this.fermon_value);
            this.aco_panel.Controls.Add(this.label9);
            this.aco_panel.Controls.Add(this.label8);
            this.aco_panel.Controls.Add(this.label7);
            this.aco_panel.Controls.Add(this.roh_text);
            this.aco_panel.Controls.Add(this.beta_text);
            this.aco_panel.Controls.Add(this.alpha_text);
            this.aco_panel.Controls.Add(this.label6);
            this.aco_panel.Controls.Add(this.aco_karinca);
            this.aco_panel.Controls.Add(this.label5);
            this.aco_panel.Controls.Add(this.aco_iteration);
            this.aco_panel.Controls.Add(this.label4);
            this.aco_panel.Location = new System.Drawing.Point(9, 43);
            this.aco_panel.Name = "aco_panel";
            this.aco_panel.Size = new System.Drawing.Size(281, 166);
            this.aco_panel.TabIndex = 3;
            this.aco_panel.Visible = false;
            // 
            // fermon_value
            // 
            this.fermon_value.DecimalPlaces = 1;
            this.fermon_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fermon_value.Location = new System.Drawing.Point(104, 133);
            this.fermon_value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fermon_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fermon_value.Name = "fermon_value";
            this.fermon_value.Size = new System.Drawing.Size(113, 20);
            this.fermon_value.TabIndex = 11;
            this.fermon_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fermon_value.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "fermon value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "beta";
            // 
            // roh_text
            // 
            this.roh_text.Location = new System.Drawing.Point(104, 105);
            this.roh_text.Name = "roh_text";
            this.roh_text.Size = new System.Drawing.Size(113, 20);
            this.roh_text.TabIndex = 7;
            this.roh_text.Text = "0.5";
            this.roh_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // beta_text
            // 
            this.beta_text.Location = new System.Drawing.Point(104, 81);
            this.beta_text.Name = "beta_text";
            this.beta_text.Size = new System.Drawing.Size(113, 20);
            this.beta_text.TabIndex = 6;
            this.beta_text.Text = "3";
            this.beta_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alpha_text
            // 
            this.alpha_text.Location = new System.Drawing.Point(104, 57);
            this.alpha_text.Name = "alpha_text";
            this.alpha_text.Size = new System.Drawing.Size(113, 20);
            this.alpha_text.TabIndex = 5;
            this.alpha_text.Text = "1";
            this.alpha_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "alpha";
            // 
            // aco_karinca
            // 
            this.aco_karinca.Location = new System.Drawing.Point(104, 31);
            this.aco_karinca.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.aco_karinca.Name = "aco_karinca";
            this.aco_karinca.Size = new System.Drawing.Size(113, 20);
            this.aco_karinca.TabIndex = 3;
            this.aco_karinca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aco_karinca.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ant";
            // 
            // aco_iteration
            // 
            this.aco_iteration.Location = new System.Drawing.Point(104, 6);
            this.aco_iteration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.aco_iteration.Name = "aco_iteration";
            this.aco_iteration.Size = new System.Drawing.Size(113, 20);
            this.aco_iteration.TabIndex = 1;
            this.aco_iteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aco_iteration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Iteration";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genetic_panel
            // 
            this.genetic_panel.Controls.Add(this.label17);
            this.genetic_panel.Controls.Add(this.label16);
            this.genetic_panel.Controls.Add(this.label15);
            this.genetic_panel.Controls.Add(this.pop_txt);
            this.genetic_panel.Controls.Add(this.cross_txt);
            this.genetic_panel.Controls.Add(this.mut_txt);
            this.genetic_panel.Controls.Add(this.label3);
            this.genetic_panel.Controls.Add(this.genetic_iteration);
            this.genetic_panel.Location = new System.Drawing.Point(7, 42);
            this.genetic_panel.Name = "genetic_panel";
            this.genetic_panel.Size = new System.Drawing.Size(284, 167);
            this.genetic_panel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Iteration";
            // 
            // genetic_iteration
            // 
            this.genetic_iteration.Location = new System.Drawing.Point(115, 112);
            this.genetic_iteration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.genetic_iteration.Name = "genetic_iteration";
            this.genetic_iteration.Size = new System.Drawing.Size(120, 20);
            this.genetic_iteration.TabIndex = 0;
            this.genetic_iteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genetic_iteration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // radio_aco
            // 
            this.radio_aco.AutoSize = true;
            this.radio_aco.Location = new System.Drawing.Point(147, 19);
            this.radio_aco.Name = "radio_aco";
            this.radio_aco.Size = new System.Drawing.Size(47, 17);
            this.radio_aco.TabIndex = 1;
            this.radio_aco.Text = "ACO";
            this.radio_aco.UseVisualStyleBackColor = true;
            this.radio_aco.CheckedChanged += new System.EventHandler(this.radio_aco_CheckedChanged);
            // 
            // radio_genetic
            // 
            this.radio_genetic.AutoSize = true;
            this.radio_genetic.Checked = true;
            this.radio_genetic.Location = new System.Drawing.Point(35, 19);
            this.radio_genetic.Name = "radio_genetic";
            this.radio_genetic.Size = new System.Drawing.Size(62, 17);
            this.radio_genetic.TabIndex = 0;
            this.radio_genetic.TabStop = true;
            this.radio_genetic.Text = "Genetic";
            this.radio_genetic.UseVisualStyleBackColor = true;
            this.radio_genetic.CheckedChanged += new System.EventHandler(this.radio_genetic_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.solution_name);
            this.groupBox3.Controls.Add(this.solution_evalute);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.percint);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 327);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solutions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(230, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 300);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // solution_name
            // 
            this.solution_name.AutoSize = true;
            this.solution_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution_name.Location = new System.Drawing.Point(9, 139);
            this.solution_name.MaximumSize = new System.Drawing.Size(210, 0);
            this.solution_name.Name = "solution_name";
            this.solution_name.Size = new System.Drawing.Size(0, 15);
            this.solution_name.TabIndex = 4;
            // 
            // solution_evalute
            // 
            this.solution_evalute.AutoSize = true;
            this.solution_evalute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution_evalute.Location = new System.Drawing.Point(150, 81);
            this.solution_evalute.Name = "solution_evalute";
            this.solution_evalute.Size = new System.Drawing.Size(0, 15);
            this.solution_evalute.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Path :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Best Solution :";
            // 
            // percint
            // 
            this.percint.AutoSize = true;
            this.percint.Location = new System.Drawing.Point(100, 42);
            this.percint.Name = "percint";
            this.percint.Size = new System.Drawing.Size(21, 13);
            this.percint.TabIndex = 1;
            this.percint.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // agri_radio
            // 
            this.agri_radio.AutoSize = true;
            this.agri_radio.Location = new System.Drawing.Point(244, 19);
            this.agri_radio.Name = "agri_radio";
            this.agri_radio.Size = new System.Drawing.Size(46, 17);
            this.agri_radio.TabIndex = 4;
            this.agri_radio.TabStop = true;
            this.agri_radio.Text = "ABC";
            this.agri_radio.UseVisualStyleBackColor = true;
            this.agri_radio.CheckedChanged += new System.EventHandler(this.agri_radio_CheckedChanged);
            // 
            // agri_panel
            // 
            this.agri_panel.Controls.Add(this.label14);
            this.agri_panel.Controls.Add(this.label13);
            this.agri_panel.Controls.Add(this.label12);
            this.agri_panel.Controls.Add(this.agri_iteration_txt);
            this.agri_panel.Controls.Add(this.limit_txt);
            this.agri_panel.Controls.Add(this.food_txt);
            this.agri_panel.Location = new System.Drawing.Point(7, 42);
            this.agri_panel.Name = "agri_panel";
            this.agri_panel.Size = new System.Drawing.Size(284, 167);
            this.agri_panel.TabIndex = 6;
            this.agri_panel.Visible = false;
            // 
            // food_txt
            // 
            this.food_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_txt.Location = new System.Drawing.Point(135, 27);
            this.food_txt.Name = "food_txt";
            this.food_txt.Size = new System.Drawing.Size(79, 20);
            this.food_txt.TabIndex = 0;
            this.food_txt.Text = "10";
            this.food_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // limit_txt
            // 
            this.limit_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit_txt.Location = new System.Drawing.Point(135, 62);
            this.limit_txt.Name = "limit_txt";
            this.limit_txt.Size = new System.Drawing.Size(79, 20);
            this.limit_txt.TabIndex = 1;
            this.limit_txt.Text = "10";
            this.limit_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agri_iteration_txt
            // 
            this.agri_iteration_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agri_iteration_txt.Location = new System.Drawing.Point(135, 97);
            this.agri_iteration_txt.Name = "agri_iteration_txt";
            this.agri_iteration_txt.Size = new System.Drawing.Size(79, 20);
            this.agri_iteration_txt.TabIndex = 2;
            this.agri_iteration_txt.Text = "10";
            this.agri_iteration_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "food";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "limit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "iteration";
            // 
            // mut_txt
            // 
            this.mut_txt.Location = new System.Drawing.Point(115, 82);
            this.mut_txt.Name = "mut_txt";
            this.mut_txt.Size = new System.Drawing.Size(120, 20);
            this.mut_txt.TabIndex = 2;
            this.mut_txt.Text = "20";
            this.mut_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cross_txt
            // 
            this.cross_txt.Location = new System.Drawing.Point(115, 52);
            this.cross_txt.Name = "cross_txt";
            this.cross_txt.Size = new System.Drawing.Size(120, 20);
            this.cross_txt.TabIndex = 3;
            this.cross_txt.Text = "80";
            this.cross_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pop_txt
            // 
            this.pop_txt.Location = new System.Drawing.Point(115, 22);
            this.pop_txt.Name = "pop_txt";
            this.pop_txt.Size = new System.Drawing.Size(120, 20);
            this.pop_txt.TabIndex = 4;
            this.pop_txt.Text = "10";
            this.pop_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Population";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Crossover";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Mutation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizasyon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.aco_panel.ResumeLayout(false);
            this.aco_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fermon_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aco_karinca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aco_iteration)).EndInit();
            this.genetic_panel.ResumeLayout(false);
            this.genetic_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genetic_iteration)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.agri_panel.ResumeLayout(false);
            this.agri_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Load_Data;
        private System.Windows.Forms.Label masar;
        private System.Windows.Forms.Label column_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label row_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_aco;
        private System.Windows.Forms.RadioButton radio_genetic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel genetic_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown genetic_iteration;
        private System.Windows.Forms.Panel aco_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown aco_iteration;
        private System.Windows.Forms.NumericUpDown aco_karinca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roh_text;
        private System.Windows.Forms.TextBox beta_text;
        private System.Windows.Forms.TextBox alpha_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown fermon_value;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label solution_name;
        private System.Windows.Forms.Label solution_evalute;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label percint;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton agri_radio;
        private System.Windows.Forms.Panel agri_panel;
        private System.Windows.Forms.TextBox agri_iteration_txt;
        private System.Windows.Forms.TextBox limit_txt;
        private System.Windows.Forms.TextBox food_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox pop_txt;
        private System.Windows.Forms.TextBox cross_txt;
        private System.Windows.Forms.TextBox mut_txt;
    }
}

