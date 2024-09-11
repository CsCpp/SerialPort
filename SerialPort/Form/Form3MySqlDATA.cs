using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortC.Class;


namespace SerialPortC
{
    public partial class Form3MySqlDATA : Form
    {
        DataSet myDataSet;
        BDmySQL bdmySQL = new BDmySQL();
        public bool showForm3 = false;

        

        public void RefreshAndShowDataOnDataGidView()
        {
            myDataSet = new DataSet();
            myDataSet = bdmySQL.ReadDataToMySqlDataBase();

            dataGridView1.DataSource = myDataSet;
            dataGridView1.DataMember = "Serial Data";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        public Form3MySqlDATA()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 362, this.Location.Y);

            RefreshAndShowDataOnDataGidView();
        }
            

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            showForm3 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showForm3 = false;
            this.Visible=false;
        }
    }
}
