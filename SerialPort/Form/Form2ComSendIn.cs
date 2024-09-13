using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SerialPortC
{
    public partial class Form2ComSendIn : Form
    {
        StreamWriter streamWriter;
        string pathFile = @"C:\1.txt";

        public Form1ComSet form1;
        public Form3MySqlDATA objForm3 = new Form3MySqlDATA();
       

        public Form2ComSendIn()
        {
            InitializeComponent();
        }
        
        public Form2ComSendIn(Form1ComSet f)
        {
            InitializeComponent();
            form1 = f;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form1.Visible = false;
            saveMySQLToolStripMenuItem.Checked = false;
            this.Text = "Терминал "+ form1.ComPortName();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          //form1.Close();
            form1.Visible = true;
            form1.ComPortClose();
        }

     
        
        public void FormUpdate(string str)
        {
            tBoxDataIN.Text += str;
            try
            {
                streamWriter = new StreamWriter(pathFile, true);
                streamWriter.WriteLine(str);
                streamWriter.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowReloadForm3();
        }

        private void comPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1.Visible == true) { form1.Visible = false; }
            else { form1.Visible = true; }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------------ТЕКСТ БОКС------------------------

        private void btnClearData_Click(object sender, EventArgs e)
        {
            tBoxDataIN.Text = "";
            tBoxDataOut.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            form1.sendDataEnter(tBoxDataOut.Text);
            ShowReloadForm3();

            tBoxDataOut.Text = "";
        }

        private void tBoxDataOut_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                form1.sendDataEnter(tBoxDataOut.Text);
                ShowReloadForm3();

                tBoxDataOut.Text = "";
            }
        }

        //----------------------Показать БАЗУ ДАННЫХ------------------------

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            objForm3.showForm3 = true;
            
          

            objForm3.Show();

        }
        //----------------------Обновить БАЗУ ДАННЫХ------------------------

        private void ShowReloadForm3()
        {
            if (objForm3.showForm3)
            {
                objForm3.RefreshAndShowDataOnDataGidView();
            }
        }



    }
}
