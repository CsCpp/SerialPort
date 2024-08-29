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
    public partial class Form3 : Form
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

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RefreshAndShowDataOnDataGidView();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            showForm3 = false;
        }
    }
}
