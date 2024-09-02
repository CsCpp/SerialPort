using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SerialPortC
{
    public partial class MySQLSet : Form
    {
        public MySQLSet()
        {
            InitializeComponent();
        }

       

        private void MySQLSet_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetDeffaultMySql(BDmySQL bdmySQL)
        {
            textBox1.Text = bdmySQL.



        }
    }
}
