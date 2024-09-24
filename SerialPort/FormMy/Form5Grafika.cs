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
        public Form5Grafika()
        {
            InitializeComponent();
        }
        public void dataIU(int varI, int varU)
        {
            label2I.Text = varI.ToString();
            label4U.Text = varU.ToString();
        }
    }
   
}
