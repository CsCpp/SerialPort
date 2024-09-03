using System;
using System.Windows.Forms;
using SerialPortC.Class;


namespace SerialPortC
{
    public partial class Form4MySQLSet : Form
    {
       
        private BDmySQL bdmySQLtemp;
      
        public Form4MySQLSet(BDmySQL bdmySQL)
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
            Form4MySQLSet.ServerLH = textBox1.Text;
            bdmySQLtemp.UsernameLH = textBox2.Text;
            bdmySQLtemp.PasswordLH = textBox3.Text;
            bdmySQLtemp.PortLH = Convert.ToInt16(textBox4.Text);
            bdmySQLtemp.DatabaseLH = textBox5.Text;
            bdmySQLtemp.TableLH = textBox6.Text;
            

           Form1ComSet.SetDataMySQLForm4(bdmySQLtemp);

          
            this.Visible = false;
        }

    }
      
    
}
