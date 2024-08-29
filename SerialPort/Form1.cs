using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SerialPortC
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;

        BDmySQL bdmySQL= new BDmySQL();


        public Form2 newForm;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
            chBoxDtrEnable.Checked=false;
            serialPort.DtrEnable = false;
            chBoxRtsEnable.Checked=false;
            serialPort.RtsEnable = false;
         

            chBoxWriteLine.Checked = false;
           
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ComPortOpen();
            
        }
        public void ComPortClose()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
             

                cBoxCOMPORT.Enabled = true;
                cBoxBAUDRATE.Enabled = true;
                cBoxDATABITS.Enabled = true;
                cBoxPARITYBITS.Enabled = true;
                cBoxSTOPBITS.Enabled = true;
           
                btnOpen.Enabled = true;
              


            }

        }
        //  ----------------------   Отправка данных -----------------------------
        public void sendDataEnter(string str)
        {
            if (serialPort.IsOpen)
            {
              try
                {
                    if (chBoxWriteLine.Checked) { serialPort.WriteLine(DateTime.Now + " : " + str); }
                    else { serialPort.Write(DateTime.Now + " : " + str); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (newForm.saveMySQLToolStripMenuItem.Checked == true)
            { 
            bdmySQL.SaveDataToMySqlDataBase(str);
            }
        }


        //  ----------------------   Получение данных -----------------------------

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN =serialPort.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            int dataINLength = dataIN.Length;
       //     lbDataINLength.Text = string.Format("{0:00}", dataINLength);
       //     tBoxDataIN.Text += dataIN.ToString();
           
            newForm.FormUpdate(dataIN.ToString());
        }

        private void cOMОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComPortOpen();
        }
        private void ComPortOpen()
        {
            try
            {
                serialPort.PortName = cBoxCOMPORT.Text;
                serialPort.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                serialPort.DataBits = Convert.ToInt32(cBoxDATABITS.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxSTOPBITS.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxPARITYBITS.Text);

                serialPort.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

         
            cBoxCOMPORT.Enabled = false;
            cBoxBAUDRATE.Enabled = false;
            cBoxDATABITS.Enabled = false;
            cBoxPARITYBITS.Enabled = false;
            cBoxSTOPBITS.Enabled = false;

         
            btnOpen.Enabled = false;
           
            chBoxWriteLine.Checked = true;

       
           
       
             newForm = new Form2(this);
             newForm.Show();
            
        }

        private void cOMЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComPortClose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDtrEnable.Checked)
            {
                serialPort.DtrEnable = true;
                MessageBox.Show("DRT Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort.DtrEnable = false;
            }
        }

        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRtsEnable.Checked)
            {
                serialPort.RtsEnable = true;
                MessageBox.Show("RST Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort.RtsEnable = false;
            }
        }


    }
}
