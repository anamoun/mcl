using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//---------
using Class1;
using System.Threading;
using System.Collections;


namespace Robot
{
    public partial class Form1 : Form
    {
        int typeX = 1; //1 size  2 Density
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList ar1 = new ArrayList();
        ArrayList ar2 = new ArrayList();
        ArrayList ar3 = new ArrayList();

        ArrayList ECM = new ArrayList();
        ArrayList MCL = new ArrayList();
        ArrayList Cloud = new ArrayList();

        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            //double x=7.1/3;
            //MessageBox.Show(Math.Ceiling(x).ToString());

            //ar1.Clear();
            //ar2.Clear();
            //ar3.Clear();
            //int []val1= {10, 20, 30 ,40, 50};
            //int [] val2 = { 5, 25, 35, 20, 50 };
            //int [] val3 = { 13, 21, 10, 30, 40 };
            //ar1.AddRange(val1);
            //ar2.AddRange(val2);
            //ar3.AddRange(val3);
            //// Config Chart ##########################################################################################
            //var objChart = chart1.ChartAreas[0];
            //objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            ////objChart.AxisX.Minimum = 1;            //objChart.AxisX.Maximum = 12;
            //objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            ////objChart.AxisY.Minimum = 0;            //objChart.AxisY.Maximum = 50;
            //chart1.Series.Clear();
            //// Config Chart ##########################################################################################
            //Drowchart(ar1, 0, "S1", 255, 0, 0);
            //Drowchart(ar2, 1, "S2", 0, 0, 255);
            //Drowchart(ar3, 2, "S3", 0, 255, 0);
        }

        void Drowchart(ArrayList a1, int t, string title, int R, int G, int B) 
        {
            try
            {
                chart1.Series.Add(title);
                chart1.Series[t].ToolTip = "#VAL{0.0} S";
                chart1.Series[t].Color = Color.FromArgb(R, G, B);
                chart1.Series[t].Legend = "Legend1";
                chart1.Series[t].ChartArea = "ChartArea1";
                chart1.Series[t].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                //adding data
                string[] X;
                if (typeX ==1)
                     X = t_SeriesSize.Text.Split('#');
                else
                    X = t_SeriesDensity_Flow.Text.Split('#');

                for (int i = 0; i < a1.Count; i++)
                {
                    if ((int)a1[i] <= 0)
                        a1[i] = "1";
                    chart1.Series[t].Points.AddXY(X[i], (int)a1[i]);
                }
            }
            catch {  }
        }


        //Generate by Size
        private void button9_Click(object sender, EventArgs e)
        {
            typeX = 1;
            try
            {
                MCL.Clear();
                ECM.Clear();
                Cloud.Clear();
                dataGridView1.Rows.Clear();

                int seq = 0;

                int EcmNode = Convert.ToInt32(t_EcmNode.Text);
                int MclNode = Convert.ToInt32(t_MclNode.Text);
                int CloudNode = Convert.ToInt32(t_CloudNode.Text);
                int EcmTime = Convert.ToInt32(t_EcmTime.Text);
                int MclTime = Convert.ToInt32(t_MclTime.Text);
                int CloudTime = Convert.ToInt32(t_CloudTime.Text);

                int EcmAdditionTime = Convert.ToInt32(t_Ecm_delay_proc.Text);
                int MclAdditionTime = Convert.ToInt32(t_Mcl_delay_proc.Text);
                int CloudAdditionTime = Convert.ToInt32(t_Cloud_delay_proc.Text);

                int TaskSize = Convert.ToInt32(t_TaskSize.Text);
                int TaskTime = Convert.ToInt32(t_TaskTime.Text);

                string [] series_size = t_SeriesSize.Text.Split('#');
                int count = series_size.Length;

                int j = 0;
                int i = 0;
                int maxVal = 0;

                while (i < count * 3) 
                {
                    double tasks= (Convert.ToDouble(series_size[j]) * 1000) / TaskSize;
                    int task_count = Convert.ToInt32(Math.Ceiling(tasks));
                    j = j + 1;
                    
                    //------
                    int Ecm_Communication_Delay = task_count * EcmTime;
                    double computings_count1 = task_count / Convert.ToDouble(EcmNode);
                    int Ecm_Computing_Delay = Convert.ToInt32(Math.Ceiling(computings_count1)) * TaskTime + Convert.ToInt32(Math.Ceiling(computings_count1)) * EcmAdditionTime;
                    int Ecm_Total_Delay = Ecm_Communication_Delay + Ecm_Computing_Delay;
                    ECM.Add(Ecm_Total_Delay);

                    if (Ecm_Total_Delay > maxVal)
                        maxVal = Ecm_Total_Delay;
                    //------ 
                    int Mcl_Communication_Delay = task_count * MclTime;
                    double computings_count2 = task_count / Convert.ToDouble(MclNode);
                    int Mcl_Computing_Delay = Convert.ToInt32(Math.Ceiling(computings_count2)) * TaskTime + Convert.ToInt32(Math.Ceiling(computings_count2)) * MclAdditionTime;
                    int Mcl_Total_Delay = Mcl_Communication_Delay + Mcl_Computing_Delay;
                    MCL.Add(Mcl_Total_Delay);

                    if (Mcl_Total_Delay > maxVal)
                        maxVal = Mcl_Total_Delay;
                    //------ 
                    int Cloud_Communication_Delay = task_count * CloudTime;
                    double computings_count3 = task_count / Convert.ToDouble(CloudNode);
                    int Cloud_Computing_Delay = Convert.ToInt32(Math.Ceiling(computings_count3)) * TaskTime + Convert.ToInt32(Math.Ceiling(computings_count3)) * CloudAdditionTime;
                    int Cloud_Total_Delay = Cloud_Communication_Delay + Cloud_Computing_Delay;
                    Cloud.Add(Cloud_Total_Delay);

                    if (Cloud_Total_Delay > maxVal)
                        maxVal = Cloud_Total_Delay;
                    //------ 

                    seq = j ;

                    //-------------------
                    i = i;
                    dataGridView1.Rows.Add();
                    dataGridView1["N", i].Value = seq;
                    dataGridView1["Type", i].Value = "MEC";
                    //dataGridView1["Type", i].Style.ForeColor = Color.Red;
                    //dataGridView1["Type", i].Style.BackColor = Color.Gainsboro;
                    dataGridView1["ComDelay", i].Value = Ecm_Communication_Delay.ToString();
                    dataGridView1["ProcessDelay", i].Value = Ecm_Computing_Delay.ToString();
                    dataGridView1["TotalDelay", i].Value = Ecm_Total_Delay.ToString();
                    //-------------------
                    i = i + 1;
                    dataGridView1.Rows.Add();
                    dataGridView1["N", i].Value = seq;
                    dataGridView1["Type", i].Value = "MCL";
                    dataGridView1["ComDelay", i].Value = Mcl_Communication_Delay.ToString();
                    dataGridView1["ProcessDelay", i].Value = Mcl_Computing_Delay.ToString();
                    dataGridView1["TotalDelay", i].Value = Mcl_Total_Delay.ToString();
                    //-------------------
                    i = i + 1;
                    dataGridView1.Rows.Add();
                    dataGridView1["N", i].Value = seq;
                    dataGridView1["Type", i].Value = "Cloud";
                    //dataGridView1["Type", i].Style.ForeColor = Color.Black;
                    //dataGridView1["Type", i].Style.BackColor = Color.Azure;
                    dataGridView1["ComDelay", i].Value = Cloud_Communication_Delay.ToString();
                    dataGridView1["ProcessDelay", i].Value = Cloud_Computing_Delay.ToString();
                    dataGridView1["TotalDelay", i].Value = Cloud_Total_Delay.ToString();       
                    //--------------------


                    if (seq % 2 == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        dataGridView1.Rows[i-1].DefaultCellStyle.ForeColor = Color.Red;
                        dataGridView1.Rows[i-2].DefaultCellStyle.ForeColor = Color.Red;
                    }

                    i = i + 1;
                } // End While 


                //--------------------------------------------------------------------------------------------------------
                // Config Chart ##########################################################################################
                chart1.Series.Clear();
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Comparison according to Total Delay");

                var objChart = chart1.ChartAreas[0];
                objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                //objChart.AxisX.Minimum = 1;
                //objChart.AxisX.Maximum = count;
                objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisY.Minimum = 0;
                objChart.AxisY.Maximum = maxVal;
                
                
                // Config Chart ##########################################################################################
                Drowchart(ECM, 0, "MEC", 255, 0, 0);
                Drowchart(MCL, 1, "MCL", 0, 0, 255);
                Drowchart(Cloud, 2, "Cloud", 0, 255, 0);
                //########################################################################################################
                //--------------------------------------------------------------------------------------------------------
                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        //#####################################################################
   
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            //if (e.StateChanged != DataGridViewElementStates.Selected)
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    int index = dataGridView1.CurrentRow.Index;
                    //-----------------------------------------
                    string type = dataGridView1["Type", index].Value.ToString();
                    int id = (int)dataGridView1["N", index].Value;
                    string total = dataGridView1["TotalDelay", index].Value.ToString();
                    int series = 0;
                    if (type == "MCL")
                        series = 1;
                    else if (type == "Cloud")
                        series = 2;

                    for (int i = 0; i < chart1.Series[0].Points.Count; i++) 
                    {
                        chart1.Series[0].Points[i].BorderWidth = 1;
                        chart1.Series[1].Points[i].BorderWidth = 1;
                        chart1.Series[2].Points[i].BorderWidth = 1;

                        chart1.Series[0].Points[i].BorderColor = Color.Black;
                        chart1.Series[1].Points[i].BorderColor = Color.Black;
                        chart1.Series[2].Points[i].BorderColor = Color.Black;
                    }
                    chart1.Series[series].Points[id - 1].BorderWidth = 2;
                    chart1.Series[series].Points[id - 1].BorderColor = Color.Black;

                    this.chart1.Titles.Clear();
                    this.chart1.Titles.Add("Total Delay of the Selected Value is:" + total);
                    chart1.Update();
                }
            }
            catch { }
        }


        //Chart Style
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Update();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Update();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                chart1.Update();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Update();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(System.Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("output.xls", System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing);

                // Exit from the application  
                //app.Quit(); 
            }
            catch { }

        }

        //Density ##########################################################################
        private void button1_Click(object sender, EventArgs e)
        {
            typeX = 2;
            try
            {
                MCL.Clear();
                ECM.Clear();
                Cloud.Clear();
                dataGridView1.Rows.Clear();

                int seq = 0;

                int EcmNode = Convert.ToInt32(t_EcmNode.Text);
                int MclNode = Convert.ToInt32(t_MclNode.Text);
                int CloudNode = Convert.ToInt32(t_CloudNode.Text);
                int EcmTime = Convert.ToInt32(t_EcmTime.Text);
                int MclTime = Convert.ToInt32(t_MclTime.Text);
                int CloudTime = Convert.ToInt32(t_CloudTime.Text);

                int EcmAdditionTime = Convert.ToInt32(t_Ecm_delay_proc.Text);
                int MclAdditionTime = Convert.ToInt32(t_Mcl_delay_proc.Text);
                int CloudAdditionTime = Convert.ToInt32(t_Cloud_delay_proc.Text);

                int TaskSize = Convert.ToInt32(t_TaskSize.Text);
                int TaskTime = Convert.ToInt32(t_TaskTime.Text);

                int PacketSize = Convert.ToInt32(textBox1.Text);
                string[] series_Flow = t_SeriesDensity_Flow.Text.Split('#');
                string[] series_size = t_SeriesDensity_Flow.Text.Split('#');

                for (int m = 0; m < series_Flow.Length; m++)
                {
                   int res =  Convert.ToInt32(series_Flow[m]) * PacketSize/1000000;
                   series_size[m] = res.ToString();
                }

                int count = series_size.Length;

                int j = 0;
                int i = 0;
                int maxVal = 0;

                while (i < count * 3)
                {
                    double tasks = (Convert.ToDouble(series_size[j]) * 1000) / TaskSize;
                    int task_count = Convert.ToInt32(Math.Ceiling(tasks));
                    j = j + 1;

                    //------
                    int Ecm_Communication_Delay = task_count * EcmTime;
                    double computings_count1 = task_count / Convert.ToDouble(EcmNode);
                    int Ecm_Computing_Delay = Convert.ToInt32(Math.Ceiling(computings_count1)) * TaskTime + Convert.ToInt32(Math.Ceiling(computings_count1)) * EcmAdditionTime;
                    int Ecm_Total_Delay = Ecm_Communication_Delay + Ecm_Computing_Delay;
                    ECM.Add(Ecm_Total_Delay);

                    if (Ecm_Total_Delay > maxVal)
                        maxVal = Ecm_Total_Delay;
                    //------ 
                    int Mcl_Communication_Delay = task_count * MclTime;
                    double computings_count2 = task_count / Convert.ToDouble(MclNode);
                    int Mcl_Computing_Delay = Convert.ToInt32(Math.Ceiling(computings_count2)) * TaskTime + Convert.ToInt32(Math.Ceiling(computings_count2)) * MclAdditionTime;
                    int Mcl_Total_Delay = Mcl_Communication_Delay + Mcl_Computing_Delay;
                    MCL.Add(Mcl_Total_Delay);

                    if (Mcl_Total_Delay > maxVal)
                        maxVal = Mcl_Total_Delay;
                    //------ 
                    int Cloud_Communication_Delay = task_count * CloudTime;
                    double computings_count3 = task_count / Convert.ToDouble(CloudNode);
                    int Cloud_Computing_Delay = Convert.ToInt32(Math.Ceiling(computings_count3)) * TaskTime + Convert.ToInt32(Math.Ceiling(computings_count3)) * CloudAdditionTime;
                    int Cloud_Total_Delay = Cloud_Communication_Delay + Cloud_Computing_Delay;
                    Cloud.Add(Cloud_Total_Delay);

                    if (Cloud_Total_Delay > maxVal)
                        maxVal = Cloud_Total_Delay;
                    //------ 

                    seq = j;

                    //-------------------
                    i = i;
                    dataGridView1.Rows.Add();
                    dataGridView1["N", i].Value = seq;
                    dataGridView1["Type", i].Value = "MEC";
                    //dataGridView1["Type", i].Style.ForeColor = Color.Red;
                    //dataGridView1["Type", i].Style.BackColor = Color.Gainsboro;
                    dataGridView1["ComDelay", i].Value = Ecm_Communication_Delay.ToString();
                    dataGridView1["ProcessDelay", i].Value = Ecm_Computing_Delay.ToString();
                    dataGridView1["TotalDelay", i].Value = Ecm_Total_Delay.ToString();
                    //-------------------
                    i = i + 1;
                    dataGridView1.Rows.Add();
                    dataGridView1["N", i].Value = seq;
                    dataGridView1["Type", i].Value = "MCL";
                    dataGridView1["ComDelay", i].Value = Mcl_Communication_Delay.ToString();
                    dataGridView1["ProcessDelay", i].Value = Mcl_Computing_Delay.ToString();
                    dataGridView1["TotalDelay", i].Value = Mcl_Total_Delay.ToString();
                    //-------------------
                    i = i + 1;
                    dataGridView1.Rows.Add();
                    dataGridView1["N", i].Value = seq;
                    dataGridView1["Type", i].Value = "Cloud";
                    //dataGridView1["Type", i].Style.ForeColor = Color.Black;
                    //dataGridView1["Type", i].Style.BackColor = Color.Azure;
                    dataGridView1["ComDelay", i].Value = Cloud_Communication_Delay.ToString();
                    dataGridView1["ProcessDelay", i].Value = Cloud_Computing_Delay.ToString();
                    dataGridView1["TotalDelay", i].Value = Cloud_Total_Delay.ToString();
                    //--------------------


                    if (seq % 2 == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        dataGridView1.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Red;
                        dataGridView1.Rows[i - 2].DefaultCellStyle.ForeColor = Color.Red;
                    }

                    i = i + 1;
                } // End While 


                //--------------------------------------------------------------------------------------------------------
                // Config Chart ##########################################################################################
                chart1.Series.Clear();
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Comparison according to Total Delay");

                var objChart = chart1.ChartAreas[0];
                objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                //objChart.AxisX.Minimum = 1;
                //objChart.AxisX.Maximum = count;
                objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisY.Minimum = 0;
                objChart.AxisY.Maximum = maxVal;


                // Config Chart ##########################################################################################
                Drowchart(ECM, 0, "MEC", 255, 0, 0);
                Drowchart(MCL, 1, "MCL", 0, 0, 255);
                Drowchart(Cloud, 2, "Cloud", 0, 255, 0);
                //########################################################################################################
                //--------------------------------------------------------------------------------------------------------

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string type = "Total";
            int x = 4;//total column 
            if (r2.Checked)
            {
                x = 3; // Processing
                type = "Processing";
            }
            else if (r1.Checked)
            {
                x = 2; //communication 
                type = "Communication";
            }
            else
            {
                x = 4;
                type = "Total";
            }

            MCL.Clear();
            ECM.Clear();
            Cloud.Clear();
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++) 
            {
                if (i % 3 == 0)
                    ECM.Add(Convert.ToInt32(dataGridView1[x, i].Value.ToString()));
                else if (i%3==1)
                    MCL.Add(Convert.ToInt32(dataGridView1[x, i].Value.ToString()));
                else
                    Cloud.Add(Convert.ToInt32(dataGridView1[x, i].Value.ToString()));
            }

            // Config Chart ##########################################################################################
            // Config Chart ##########################################################################################
            chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Comparison according to " + type +" Delay");

            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //objChart.AxisX.Minimum = 1;
            //objChart.AxisX.Maximum = count;
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            int maxVal=0;
            for (int j = 0; j < ECM.Count; j++)
            {
                int p=Convert.ToInt32(ECM[j].ToString());
                if ( p> maxVal)
                    maxVal = p;

                p = Convert.ToInt32(MCL[j].ToString());
                if (p > maxVal)
                    maxVal = p;

                p = Convert.ToInt32(Cloud[j].ToString());
                if (p > maxVal)
                    maxVal = p;
            }
            objChart.AxisY.Maximum = maxVal;

            
            Drowchart(ECM, 0, "MEC", 255, 0, 0);
            Drowchart(MCL, 1, "MCL", 0, 0, 255);
            Drowchart(Cloud, 2, "Cloud", 0, 255, 0);
            //########################################################################################################
            
        }
        
        

       
        //##########################################################################################
        //##########################################################################################


    }
}
