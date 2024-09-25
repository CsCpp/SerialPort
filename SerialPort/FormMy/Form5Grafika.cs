using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortC
{
    public partial class Form5Grafika : Form
    {
        public Form5Grafika(string str)
        {
            InitializeComponent();
            this.Text = "VoltAmpetr is " + str;
        }
        public void dataIU(int varI, int varU)
        {
            label2I.Text ="I="+ varI.ToString()+" A";
            label4U.Text ="U="+ varU.ToString()+" V";
            this.chart1.Series[0].Points.AddY(varI);
            this.chart1.Series[1].Points.AddY(varU);
        }

        private void Form5Grafika_Load(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
   
}
