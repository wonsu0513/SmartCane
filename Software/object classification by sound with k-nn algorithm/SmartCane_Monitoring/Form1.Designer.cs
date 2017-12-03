namespace SmartCane_Monitoring
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort_conboBox = new System.Windows.Forms.ComboBox();
            this.Serial_connect = new System.Windows.Forms.Button();
            this.Serial_Stop = new System.Windows.Forms.Button();
            this.Serial_Port_COM = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.serialPort_conboBox);
            this.groupBox4.Controls.Add(this.Serial_connect);
            this.groupBox4.Controls.Add(this.Serial_Stop);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(855, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(224, 203);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "K-Value";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11"});
            this.comboBox1.Location = new System.Drawing.Point(9, 148);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 24);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.Text = "3";
            // 
            // serialPort_conboBox
            // 
            this.serialPort_conboBox.FormattingEnabled = true;
            this.serialPort_conboBox.Location = new System.Drawing.Point(9, 25);
            this.serialPort_conboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serialPort_conboBox.Name = "serialPort_conboBox";
            this.serialPort_conboBox.Size = new System.Drawing.Size(91, 24);
            this.serialPort_conboBox.TabIndex = 24;
            this.serialPort_conboBox.DropDown += new System.EventHandler(this.serialPort_conboBox_DropDown);
            // 
            // Serial_connect
            // 
            this.Serial_connect.Font = new System.Drawing.Font("굴림", 9F);
            this.Serial_connect.Location = new System.Drawing.Point(9, 69);
            this.Serial_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Serial_connect.Name = "Serial_connect";
            this.Serial_connect.Size = new System.Drawing.Size(89, 37);
            this.Serial_connect.TabIndex = 5;
            this.Serial_connect.Text = "Connect";
            this.Serial_connect.UseVisualStyleBackColor = true;
            this.Serial_connect.Click += new System.EventHandler(this.Serial_connect_Click);
            // 
            // Serial_Stop
            // 
            this.Serial_Stop.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Serial_Stop.Location = new System.Drawing.Point(112, 69);
            this.Serial_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Serial_Stop.Name = "Serial_Stop";
            this.Serial_Stop.Size = new System.Drawing.Size(89, 35);
            this.Serial_Stop.TabIndex = 7;
            this.Serial_Stop.Text = "Disconnect";
            this.Serial_Stop.UseVisualStyleBackColor = true;
            this.Serial_Stop.Click += new System.EventHandler(this.Serial_Stop_Click);
            // 
            // Serial_Port_COM
            // 
            this.Serial_Port_COM.BaudRate = 115200;
            this.Serial_Port_COM.PortName = "COM8";
            this.Serial_Port_COM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_Port_COM_DataReceived);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Frequency, Hz";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Amplitude, dB";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.MarkerSize = 10;
            series1.Name = "Wood";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 5;
            series2.MarkerSize = 10;
            series2.Name = "Paper";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 5;
            series3.MarkerSize = 10;
            series3.Name = "Plastic";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerSize = 10;
            series4.Name = "Metal";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.Red;
            series5.MarkerBorderWidth = 2;
            series5.MarkerColor = System.Drawing.Color.Yellow;
            series5.MarkerSize = 20;
            series5.Name = "New";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series6.Legend = "Legend1";
            series6.MarkerBorderColor = System.Drawing.Color.Red;
            series6.MarkerBorderWidth = 3;
            series6.MarkerColor = System.Drawing.Color.Transparent;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "KNN";
            series6.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(849, 555);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(855, 223);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 332);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 565);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox serialPort_conboBox;
        private System.Windows.Forms.Button Serial_connect;
        private System.Windows.Forms.Button Serial_Stop;
        private System.IO.Ports.SerialPort Serial_Port_COM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

