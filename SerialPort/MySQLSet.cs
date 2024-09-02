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
       
        private BDmySQL bdmySQLtemp;
        public MySQLSet(BDmySQL bdmySQL)
        {
            InitializeComponent();
                  
            bdmySQLtemp = bdmySQL;

        }

       

        private void MySQLSet_Load(object sender, EventArgs e)
        {

            textBox1.Text = bdmySQLtemp.ServerLH;
            textBox2.Text = bdmySQLtemp.UsernameLH;
            textBox3.Text = bdmySQLtemp.PasswordLH;
            textBox4.Text = Convert.ToString(bdmySQLtemp.PortLH);
            textBox5.Text = bdmySQLtemp.DatabaseLH;
            textBox6.Text = bdmySQLtemp.TableLH;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bdmySQLtemp.ServerLH = textBox1.Text;
            bdmySQLtemp.UsernameLH = textBox2.Text;
            bdmySQLtemp.PasswordLH = textBox3.Text;
            bdmySQLtemp.PortLH = Convert.ToInt16(textBox4.Text);
            bdmySQLtemp.DatabaseLH = textBox5.Text;
            bdmySQLtemp.TableLH = textBox6.Text;

           Form1.SetDataMySQLForm4(bdmySQLtemp);

          
            this.Visible = false;
        }

    }
      
    
}
