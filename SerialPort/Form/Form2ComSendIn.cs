﻿using System;
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


namespace SerialPortC
{
    public partial class Form2ComSendIn : Form
    {
        StreamWriter streamWriter;
        string pathFile = @"C:\1.txt";

        

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
            addForm3Objct();
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
            ShowReloadForm3();
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

        private void sendData()
        {
            form1.sendDataEnter(tBoxDataOut.Text);
            addForm3Objct();
            ShowReloadForm3();
            tBoxDataOut.Text = "";
        }

        //----------------------Показать БАЗУ ДАННЫХ------------------------

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm3Objct();
            objForm3.Show();
        }

        public void addForm3Objct()
        {
            if (Form3MySqlDATA.activForm3Status == false)
            {
                objForm3 = new Form3MySqlDATA(form1.ComPortName());
            }
           
        }
        //----------------------Обновить БАЗУ ДАННЫХ------------------------

        public void ShowReloadForm3()
        {
            addForm3Objct();
            objForm3.RefreshAndShowDataOnDataGidView();
            
        }

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
                     // form1.sendDataEnter(Convert.ToString($"I={random.Next(0, 255)}A U={random.Next(0, 255)}V \n\r"));
                 tBoxDataOut.Text = (Convert.ToString($"I={random.Next(1,19)}A U={random.Next(9, 16)}V \n"));
                 Thread.Sleep(1000);
                 sendData();
                }
                else
                {
                    break;
                }
            }
        }


    }
}
