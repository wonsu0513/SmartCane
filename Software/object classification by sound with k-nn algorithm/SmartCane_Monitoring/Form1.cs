using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCane_Monitoring
{
    public partial class Form1 : Form
    {
        public const int Datalength = 400; //4096
        public const int R = 50;

        string[] strWONSU0513 = new string[3];
        string[,] total_data = new string[Datalength, 5];
        string[] recevier_data = new string[2];
        


        public Form1()
        {
            InitializeComponent();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 1000;
            chart1.ChartAreas[0].AxisY.Minimum = 50;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
         


            string input_1_path = @"C:\Users\wonsu\Documents\GitHub\MonitoringSensorData\soundMonitoring\SmartCane_Monitoring\SmartCane_Monitoring\wood.txt";
            string[] input_1_name = System.IO.File.ReadAllLines(input_1_path);

            for (int i = 0; i < input_1_name.Length; i++)
            {
                string[] split_data = input_1_name[i].Split(';');
                string[] second_split_data = split_data[0].Split(',');

                chart1.Series["Wood"].Points.AddXY(int.Parse(second_split_data[0]), float.Parse(second_split_data[1]));


                total_data[i, 0] = second_split_data[0];
                total_data[i, 1] = second_split_data[1];
                total_data[i, 2] = "wood"; //types
                total_data[i, 3] = ""; //distance
                total_data[i, 4] = ""; //rank


            }

            string input_2_path = @"C:\Users\wonsu\Documents\GitHub\MonitoringSensorData\soundMonitoring\SmartCane_Monitoring\SmartCane_Monitoring\paper.txt";
            string[] input_2_name = System.IO.File.ReadAllLines(input_2_path);

            for (int i = 0; i < input_2_name.Length; i++)
            {
                string[] split_data = input_2_name[i].Split(';');
                string[] second_split_data = split_data[0].Split(',');

                chart1.Series["Paper"].Points.AddXY(int.Parse(second_split_data[0]), float.Parse(second_split_data[1]));
                total_data[i + Datalength / 4, 0] = second_split_data[0];
                total_data[i + Datalength / 4, 1] = second_split_data[1];
                total_data[i + Datalength / 4, 2] = "paper"; //types
                total_data[i + Datalength / 4, 3] = ""; //distance
                total_data[i + Datalength / 4, 4] = ""; //rank

            }


            string input_3_path = @"C:\Users\wonsu\Documents\GitHub\MonitoringSensorData\soundMonitoring\SmartCane_Monitoring\SmartCane_Monitoring\plastic.txt";
            string[] input_3_name = System.IO.File.ReadAllLines(input_3_path);

            for (int i = 0; i < input_3_name.Length; i++)
            {
                string[] split_data = input_3_name[i].Split(';');
                string[] second_split_data = split_data[0].Split(',');

                chart1.Series["Plastic"].Points.AddXY(int.Parse(second_split_data[0]), float.Parse(second_split_data[1]));
                total_data[i + Datalength / 2, 0] = second_split_data[0];
                total_data[i + Datalength / 2, 1] = second_split_data[1];
                total_data[i + Datalength / 2, 2] = "plastic"; //types
                total_data[i + Datalength / 2, 3] = ""; //distance
                total_data[i + Datalength / 2, 4] = ""; //rank

            }

            string input_4_path = @"C:\Users\wonsu\Documents\GitHub\MonitoringSensorData\soundMonitoring\SmartCane_Monitoring\SmartCane_Monitoring\metal.txt";

            string[] input_4_name = System.IO.File.ReadAllLines(input_4_path);

            for (int i = 0; i < input_4_name.Length; i++)
            {
                string[] split_data = input_4_name[i].Split(';');
                string[] second_split_data = split_data[0].Split(',');

                chart1.Series["Metal"].Points.AddXY(int.Parse(second_split_data[0]), float.Parse(second_split_data[1]));
                total_data[i + Datalength / 4 * 3, 0] = second_split_data[0];
                total_data[i + Datalength / 4 * 3, 1] = second_split_data[1];
                total_data[i + Datalength / 4 * 3, 2] = "metal"; //types
                total_data[i + Datalength / 4 * 3, 3] = ""; //distance
                total_data[i + Datalength / 4 * 3, 4] = ""; //rank


            }
          
        }

        private void Serial_Port_COM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string strReceivedData = Serial_Port_COM.ReadLine();
            if (strReceivedData.Length == 0)
                return;
            else
            {
                strWONSU0513 = strReceivedData.Split(',',';');
                recevier_data[0] = strWONSU0513[0];
                recevier_data[1] = strWONSU0513[1];

                this.Invoke(new EventHandler(KNN_Method));
            }
        }


        private void KNN_Method(object s, EventArgs e)
        {
            richTextBox1.Clear();

            chart1.Series["New"].Points.Clear();
            chart1.Series["KNN"].Points.Clear();

            //for TEST 
          
            chart1.Series["New"].Points.AddXY(int.Parse(recevier_data[0]), float.Parse(recevier_data[1]));
            Invoke(new Action(() => richTextBox1.AppendText(recevier_data[0] + "," + recevier_data[1] + "\n")));

            Distance_KNN();
            SortRank_KNN();
            FindDataName_KNN();
        }


        private void Distance_KNN()
        {
            double distance = 0;
            double X, Y;
            
            for(int i=0;i< Datalength; i++)
            {
                if (total_data[i, 0] == null)
                    return;

                X = Math.Pow( double.Parse(recevier_data[0])- double.Parse(total_data[i, 0]), 2);//(x1-x2)^2
                Y =Math.Pow(double.Parse(recevier_data[1])-double.Parse(total_data[i, 1]), 2);//(y1-y2)^2
                distance = Math.Round(Math.Sqrt(X + Y),2);
                total_data[i, 3] = System.Convert.ToString(distance);            
            }
        }


        private void SortRank_KNN()
        {
            string temp0,temp1,temp2, temp3, temp4 ;

            
            for (int i = 0; i < Datalength; i++)
            {
                for (int j = i + 1; j < Datalength; j++)
                {
                    if (double.Parse(total_data[i, 3]) > double.Parse(total_data[j, 3]))
                    {
                        temp0 = total_data[i, 0];
                        temp1 = total_data[i, 1];
                        temp2 = total_data[i, 2];
                        temp3 = total_data[i, 3];
                        temp4 = total_data[i, 4];
                      
                        total_data[i, 0] = total_data[j, 0];
                        total_data[i, 1] = total_data[j, 1];
                        total_data[i, 2] = total_data[j, 2];
                        total_data[i, 3] = total_data[j, 3];
                        total_data[i, 4] = total_data[j, 4];

                        total_data[j, 0] = temp0;
                        total_data[j, 1] = temp1;
                        total_data[j, 2] = temp2;
                        total_data[j, 3] = temp3;
                        total_data[j, 4] =temp4;
                        
                    }
                }
            }
            
        }

        private void FindDataName_KNN()
        {           
            double K_value = double.Parse(comboBox1.Text);
            double wood_Num = 0;
            double paper_Num = 0;
            double plastic_Num = 0;
            double metal_Num = 0;
      
                for (int i = 0; i < K_value; i++)
                {
                    if (total_data[i, 2] == "wood")
                        wood_Num++;
                    else if (total_data[i, 2] == "paper")
                        paper_Num++;
                    else if (total_data[i, 2] == "plastic")
                        plastic_Num++;
                    else if (total_data[i, 2] == "metal")
                        metal_Num++;
                }


                double[] Count_num = { wood_Num, paper_Num, plastic_Num, metal_Num };

                richTextBox1.AppendText("Wood=" + wood_Num);
                richTextBox1.AppendText(System.Environment.NewLine);
                richTextBox1.AppendText("Paper=" + paper_Num);
                richTextBox1.AppendText(System.Environment.NewLine);
                richTextBox1.AppendText("Plastic=" + plastic_Num);
                richTextBox1.AppendText(System.Environment.NewLine);
                richTextBox1.AppendText("Metal=" + metal_Num);
                richTextBox1.AppendText(System.Environment.NewLine);



                for (int i = 0; i < K_value; i++)
                {
                    chart1.Series["KNN"].Points.AddXY(int.Parse(total_data[i, 0]), float.Parse(total_data[i, 1]));
                    richTextBox1.AppendText("("+1+")" + total_data[i, 0] + "/" + total_data[i, 1] + "/" + total_data[i, 3]);
                    richTextBox1.AppendText(System.Environment.NewLine);

                }

                double maxValue = Count_num.Max();
                double maxIndex = Count_num.ToList().IndexOf(maxValue);

                if (maxIndex == 0)
                {
                    richTextBox1.AppendText("Wood");
                    richTextBox1.AppendText(System.Environment.NewLine);
                }

                else if (maxIndex == 1)
                {
                    richTextBox1.AppendText("Paper");
                    richTextBox1.AppendText(System.Environment.NewLine);

                }

                else if (maxIndex == 2)
                {
                    richTextBox1.AppendText("Plastic");
                    richTextBox1.AppendText(System.Environment.NewLine);

                }

                else if (maxIndex == 3)
                {
                    richTextBox1.AppendText("Metal");
                    richTextBox1.AppendText(System.Environment.NewLine);
                }

     
        }

        private void Serial_connect_Click(object sender, EventArgs e)
        {

            try
            {
                Serial_Port_COM.PortName = serialPort_conboBox.Text;
                Serial_Port_COM.Open(); //시리얼 열기  

                if (Serial_Port_COM.IsOpen)
                {
                    Invoke(new Action(() => richTextBox1.Clear()));
                    Invoke(new Action(() => MessageBox.Show("Connect to Serial port" + serialPort_conboBox.Text + "\n")));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select the number of serial");
                return;
            }
        }
     

        private void Serial_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                Serial_Port_COM.Close();
                richTextBox1.AppendText("Disconnect" + '\n');
            }
            catch
            {

            }
        }

        private void serialPort_conboBox_DropDown(object sender, EventArgs e)
        {
            serialPort_conboBox.Text = "";
            serialPort_conboBox.Items.Clear();
            string[] s;
            s = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0; i < s.Length; i++)
            {
                serialPort_conboBox.Items.Add(s[i]);
            }
        }
    }
}
