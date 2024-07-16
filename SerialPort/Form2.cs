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
    public partial class Form2 : Form
    {
        public Form1 form1;
        public string dataIN;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          //form1.Close();
            form1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.Visible == true) { form1.Visible = false; }
            else { form1.Visible = true; }
            
        }
        public void FormUpdate()
        {
            tBoxDataIN.Text += dataIN.ToString();
        }
    }
}
