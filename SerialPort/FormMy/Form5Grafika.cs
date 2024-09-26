using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialPortC
{
    public partial class Form5Grafika : Form
    {
        private DateTime valMaxTime;
        private DateTime valMinTime;
        private DateTime startTime;
        public Form5Grafika(string str)
        {
            InitializeComponent();
            this.Text = "VoltAmpetr is " + str;
           
        }
        public void dataIU(int varI, int varU)
        {
            label2I.Text ="I="+ varI.ToString()+" A";
            label4U.Text ="U="+ varU.ToString()+" V";
            this.chart1.Series[0].Points.AddXY(DateTime.Now, varI);
            this.chart1.Series[1].Points.AddXY(DateTime.Now, varU);
            if (DateTime.Now >= valMaxTime)
            {
                valMaxTime=valMaxTime.AddSeconds(1);
                valMinTime= valMinTime.AddSeconds(1);
                chart1.ChartAreas[0].AxisX.Minimum = valMinTime.ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = valMaxTime.ToOADate();
            }
        }

        private void Form5Grafika_Load(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
           
            chart1.ChartAreas[0].AxisY.Maximum = 20;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            startTime = valMinTime = DateTime.Now;
            chart1.ChartAreas[0].AxisX.Minimum = valMinTime.ToOADate();
            valMaxTime= DateTime.Now.AddMinutes(1);
            chart1.ChartAreas[0].AxisX.Maximum = valMaxTime.ToOADate();

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 5;

          
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valMinTime = startTime;
            chart1.ChartAreas[0].AxisX.Minimum = valMinTime.ToOADate();
          
        }
    }
   
}
