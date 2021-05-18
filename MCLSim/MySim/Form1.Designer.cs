namespace Robot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_CloudNode = new System.Windows.Forms.TextBox();
            this.t_MclNode = new System.Windows.Forms.TextBox();
            this.t_EcmNode = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_CloudTime = new System.Windows.Forms.TextBox();
            this.t_MclTime = new System.Windows.Forms.TextBox();
            this.t_EcmTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t_TaskTime = new System.Windows.Forms.TextBox();
            this.t_TaskSize = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.t_Cloud_delay_proc = new System.Windows.Forms.TextBox();
            this.t_Mcl_delay_proc = new System.Windows.Forms.TextBox();
            this.t_Ecm_delay_proc = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.t_SeriesSize = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t_SeriesDensity_Flow = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(14, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(345, 23);
            this.button9.TabIndex = 25;
            this.button9.Text = "Generate -- Depends on Size";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.t_CloudNode);
            this.groupBox4.Controls.Add(this.t_MclNode);
            this.groupBox4.Controls.Add(this.t_EcmNode);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(581, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 104);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number of Nodes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cloud Nodes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "MCL Nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "MEC Nodes";
            // 
            // t_CloudNode
            // 
            this.t_CloudNode.Location = new System.Drawing.Point(89, 74);
            this.t_CloudNode.Name = "t_CloudNode";
            this.t_CloudNode.Size = new System.Drawing.Size(76, 20);
            this.t_CloudNode.TabIndex = 27;
            this.t_CloudNode.Text = "10";
            // 
            // t_MclNode
            // 
            this.t_MclNode.Location = new System.Drawing.Point(89, 48);
            this.t_MclNode.Name = "t_MclNode";
            this.t_MclNode.Size = new System.Drawing.Size(76, 20);
            this.t_MclNode.TabIndex = 26;
            this.t_MclNode.Text = "5";
            // 
            // t_EcmNode
            // 
            this.t_EcmNode.Location = new System.Drawing.Point(89, 22);
            this.t_EcmNode.Name = "t_EcmNode";
            this.t_EcmNode.Size = new System.Drawing.Size(76, 20);
            this.t_EcmNode.TabIndex = 25;
            this.t_EcmNode.Text = "1";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(14, 71);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 23);
            this.button11.TabIndex = 27;
            this.button11.Text = "Line";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cloud Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(786, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "MCL Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(786, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "MEC Time";
            // 
            // t_CloudTime
            // 
            this.t_CloudTime.Location = new System.Drawing.Point(864, 81);
            this.t_CloudTime.Name = "t_CloudTime";
            this.t_CloudTime.Size = new System.Drawing.Size(76, 20);
            this.t_CloudTime.TabIndex = 33;
            this.t_CloudTime.Text = "500";
            // 
            // t_MclTime
            // 
            this.t_MclTime.Location = new System.Drawing.Point(864, 55);
            this.t_MclTime.Name = "t_MclTime";
            this.t_MclTime.Size = new System.Drawing.Size(76, 20);
            this.t_MclTime.TabIndex = 32;
            this.t_MclTime.Text = "100";
            // 
            // t_EcmTime
            // 
            this.t_EcmTime.Location = new System.Drawing.Point(864, 29);
            this.t_EcmTime.Name = "t_EcmTime";
            this.t_EcmTime.Size = new System.Drawing.Size(76, 20);
            this.t_EcmTime.TabIndex = 31;
            this.t_EcmTime.Text = "40";
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(776, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 104);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Avg Time per Task";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.t_TaskTime);
            this.groupBox2.Controls.Add(this.t_TaskSize);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(581, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 104);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Packet Size K";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(89, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(11, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Process Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(11, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Size (MB)";
            // 
            // t_TaskTime
            // 
            this.t_TaskTime.Location = new System.Drawing.Point(88, 48);
            this.t_TaskTime.Name = "t_TaskTime";
            this.t_TaskTime.Size = new System.Drawing.Size(76, 20);
            this.t_TaskTime.TabIndex = 27;
            this.t_TaskTime.Text = "100";
            // 
            // t_TaskSize
            // 
            this.t_TaskSize.Location = new System.Drawing.Point(89, 22);
            this.t_TaskSize.Name = "t_TaskSize";
            this.t_TaskSize.Size = new System.Drawing.Size(76, 20);
            this.t_TaskSize.TabIndex = 25;
            this.t_TaskSize.Text = "200";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.t_Cloud_delay_proc);
            this.groupBox3.Controls.Add(this.t_Mcl_delay_proc);
            this.groupBox3.Controls.Add(this.t_Ecm_delay_proc);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(776, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 104);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[Optional] Processing Delay";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Cloud Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "MCL Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "MEC Time";
            // 
            // t_Cloud_delay_proc
            // 
            this.t_Cloud_delay_proc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.t_Cloud_delay_proc.Location = new System.Drawing.Point(89, 74);
            this.t_Cloud_delay_proc.Name = "t_Cloud_delay_proc";
            this.t_Cloud_delay_proc.Size = new System.Drawing.Size(76, 20);
            this.t_Cloud_delay_proc.TabIndex = 27;
            this.t_Cloud_delay_proc.Text = "0";
            // 
            // t_Mcl_delay_proc
            // 
            this.t_Mcl_delay_proc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.t_Mcl_delay_proc.Location = new System.Drawing.Point(89, 48);
            this.t_Mcl_delay_proc.Name = "t_Mcl_delay_proc";
            this.t_Mcl_delay_proc.Size = new System.Drawing.Size(76, 20);
            this.t_Mcl_delay_proc.TabIndex = 26;
            this.t_Mcl_delay_proc.Text = "0";
            // 
            // t_Ecm_delay_proc
            // 
            this.t_Ecm_delay_proc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.t_Ecm_delay_proc.Location = new System.Drawing.Point(89, 22);
            this.t_Ecm_delay_proc.Name = "t_Ecm_delay_proc";
            this.t_Ecm_delay_proc.Size = new System.Drawing.Size(76, 20);
            this.t_Ecm_delay_proc.TabIndex = 25;
            this.t_Ecm_delay_proc.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.t_SeriesSize);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox5.Location = new System.Drawing.Point(581, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(373, 84);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Series (Size of Generated Data by Unit Time) GB -- e.g. 1#2#3#4#5#10";
            // 
            // t_SeriesSize
            // 
            this.t_SeriesSize.BackColor = System.Drawing.Color.GhostWhite;
            this.t_SeriesSize.Location = new System.Drawing.Point(14, 25);
            this.t_SeriesSize.Name = "t_SeriesSize";
            this.t_SeriesSize.Size = new System.Drawing.Size(345, 20);
            this.t_SeriesSize.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.Type,
            this.ComDelay,
            this.ProcessDelay,
            this.TotalDelay});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(563, 242);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // N
            // 
            this.N.HeaderText = "N#";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // ComDelay
            // 
            this.ComDelay.HeaderText = "ComDelay";
            this.ComDelay.Name = "ComDelay";
            // 
            // ProcessDelay
            // 
            this.ProcessDelay.HeaderText = "ProcessDelay";
            this.ProcessDelay.Name = "ProcessDelay";
            // 
            // TotalDelay
            // 
            this.TotalDelay.HeaderText = "TotalDelay";
            this.TotalDelay.Name = "TotalDelay";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.t_SeriesDensity_Flow);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox6.Location = new System.Drawing.Point(581, 316);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 82);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Series (Traffic Density or Num SVs by Time Unit) e.g. 10000#20000#..";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(14, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Generate -- Depends on Density | Vehicles Numbers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_SeriesDensity_Flow
            // 
            this.t_SeriesDensity_Flow.BackColor = System.Drawing.Color.LavenderBlush;
            this.t_SeriesDensity_Flow.Location = new System.Drawing.Point(14, 23);
            this.t_SeriesDensity_Flow.Name = "t_SeriesDensity_Flow";
            this.t_SeriesDensity_Flow.Size = new System.Drawing.Size(345, 20);
            this.t_SeriesDensity_Flow.TabIndex = 25;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chart1);
            this.groupBox7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox7.Location = new System.Drawing.Point(12, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(563, 303);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chart Area";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.IsDockedInsideChartArea = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 13);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(557, 284);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.r3);
            this.groupBox8.Controls.Add(this.r2);
            this.groupBox8.Controls.Add(this.r1);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.button11);
            this.groupBox8.ForeColor = System.Drawing.Color.Red;
            this.groupBox8.Location = new System.Drawing.Point(581, 404);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(373, 125);
            this.groupBox8.TabIndex = 41;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chart Style";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.ForeColor = System.Drawing.Color.Green;
            this.button6.Location = new System.Drawing.Point(14, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Change Inputs";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Checked = true;
            this.r3.ForeColor = System.Drawing.Color.Green;
            this.r3.Location = new System.Drawing.Point(307, 22);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(49, 17);
            this.r3.TabIndex = 33;
            this.r3.TabStop = true;
            this.r3.Text = "Total";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.ForeColor = System.Drawing.Color.Green;
            this.r2.Location = new System.Drawing.Point(223, 21);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(77, 17);
            this.r2.TabIndex = 32;
            this.r2.Text = "Processing";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.ForeColor = System.Drawing.Color.Green;
            this.r1.Location = new System.Drawing.Point(123, 21);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(97, 17);
            this.r1.TabIndex = 31;
            this.r1.Text = "Communication";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(14, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Column";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(192, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "BoxPlot";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(192, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Bar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(581, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(373, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "Open in Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 570);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_CloudTime);
            this.Controls.Add(this.t_MclTime);
            this.Controls.Add(this.t_EcmTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCL - Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_CloudTime;
        private System.Windows.Forms.TextBox t_MclTime;
        private System.Windows.Forms.TextBox t_EcmTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_CloudNode;
        private System.Windows.Forms.TextBox t_MclNode;
        private System.Windows.Forms.TextBox t_EcmNode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_TaskTime;
        private System.Windows.Forms.TextBox t_TaskSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox t_Cloud_delay_proc;
        private System.Windows.Forms.TextBox t_Mcl_delay_proc;
        private System.Windows.Forms.TextBox t_Ecm_delay_proc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox t_SeriesSize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDelay;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox t_SeriesDensity_Flow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.Button button6;
    }
}

