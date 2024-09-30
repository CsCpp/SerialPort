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
using System.Threading;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using System.Runtime.InteropServices;



namespace SerialPortC
{
    public partial class Form2ComSendIn : Form
    {
        StreamWriter streamWriter;
        string pathFile = @"C:\1.txt";

        public Form5Grafika form5Grafika;

        public Form1ComSet form1;
        public Form3MySqlDATA objForm3;

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
            form1.Visible = true;
            form1.ComPortClose();
        }
        
        public void FormUpdate(string str)
        {
           sortData(str);
           tBoxDataIN.Text += str;
            onForm3();
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
            sendData();
        }

        private void tBoxDataOut_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendData();
            }
        }

        private async Task sendData()
        {
           await form1.sendDataEnter(tBoxDataOut.Text);
           await onForm3();
            tBoxDataOut.Text = "";
        }

        //----------------------Показать БАЗУ ДАННЫХ------------------------

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onForm3();
            objForm3.Show();
        }

       

        //----------------------Вкл. обманку данных -------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
             new Thread(() => randomZUmanka()).Start();
            }
        }

        private void randomZUmanka()
        {
            Random random = new Random();
            while (true)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        form1.sendDataEnter(Convert.ToString($"I={random.Next(1, 19)}A U={random.Next(9, 16)}V \n"));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                         Thread.Sleep(1000);
                }
                else
                {
                    break;
                }
            }
        }
        //-----------------------Сортировка----------------------------------
        private  void sortData(string str)
        {
            int indexOfI = str.LastIndexOf("I=") + 2;
            int indexOfU = str.LastIndexOf("U=") + 2;
            string tempI = "";
            string tempU = "";
            int varI = 0;
            int varU = 0;

            for (int i = indexOfI; i < str.Length; i++)
            {
                if (str[i] == 'A') break;
                tempI += str[i];
            }
            for (int i = indexOfU; i < str.Length; i++)
            {
                if (str[i] == 'V') break;
                tempU += str[i];
            }
            try
            {
                varI = Convert.ToInt32(tempI);
                varU = Convert.ToInt32(tempU);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            //form5Grafika ??= new Form5Grafika(form1.ComPortName()); для 8 С#

            if (form5Grafika == null)
            {
                form5Grafika=  new Form5Grafika(form1.ComPortName());
                form5Grafika.FormClosing += onForm5Closed;
                form5Grafika.Show();
            }
            
            
            form5Grafika.dataIU(varI, varU);
            
        }
        
        private void onForm5Closed(object sender, FormClosingEventArgs e)
        {
                form5Grafika.FormClosing -= onForm5Closed;
                form5Grafika = null;
        }

        private async Task onForm3()
        {
            if (objForm3 == null)
            {
                objForm3 = new Form3MySqlDATA(form1.ComPortName());
                objForm3.FormClosing += onForm3Closed;
            }
           await objForm3.RefreshAndShowDataOnDataGidView();
        }
        private void onForm3Closed(object sender, FormClosingEventArgs e)
        {
            objForm3.FormClosing -= onForm3Closed;
            objForm3 = null;
        }


    }
}
