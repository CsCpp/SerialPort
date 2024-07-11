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

namespace SerialPortC
{
    public partial class Form1 : Form
    {
        string dataOut;
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
            chBoxUsingButton.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cBoxCOMPORT.Text;
                serialPort.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                serialPort.DataBits = Convert.ToInt32(cBoxDATABITS.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxSTOPBITS.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxPARITYBITS.Text);

                serialPort.Open();
                progressBar1.Value = 100;
                cBoxCOMPORT.Enabled = false;
                cBoxBAUDRATE.Enabled = false;
                cBoxDATABITS.Enabled = false;
                cBoxPARITYBITS.Enabled = false;
                cBoxSTOPBITS.Enabled = false;

                btnCLOSE.Enabled = true;
                btnSend.Enabled = true;
                btnOpen.Enabled = false;
                chBoxUsingButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                progressBar1.Value = 0;
              
                cBoxCOMPORT.Enabled = true;
                cBoxBAUDRATE.Enabled = true;
                cBoxDATABITS.Enabled = true;
                cBoxPARITYBITS.Enabled = true;
                cBoxSTOPBITS.Enabled = true;
                btnCLOSE.Enabled = false;
                btnSend.Enabled = false;
                btnOpen.Enabled = true;
                chBoxUsingButton.Enabled = false;
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
               
                try
                {
                    dataOut = DateTime.Today + " :  "+ tBoxDataOut.Text;
                    serialPort.WriteLine(dataOut);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDtrEnable.Checked)
            {
                serialPort.DtrEnable= true;
            }
            else
            {
                serialPort.DtrEnable = false;
            }
        }

        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRtsEnable.Checked)
            {  serialPort.RtsEnable= true;}
            else
            {
                serialPort.RtsEnable = false;
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            if(tBoxDataOut.Text!="")
            { tBoxDataOut.Text = ""; }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOUTLength=tBoxDataOut.TextLength;
            lblDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
        }

        private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxUsingButton.Checked)
            {
                btnSend.Enabled = false;
            }
            else
            {
                btnSend.Enabled = true;
            }
        }
    }
}
