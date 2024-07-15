namespace SerialPortC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRtsEnable = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.cBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.cBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.cBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbDataINLength = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.chBoxUsingButton = new System.Windows.Forms.CheckBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRtsEnable);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxPARITYBITS);
            this.groupBox1.Controls.Add(this.cBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.cBoxDATABITS);
            this.groupBox1.Controls.Add(this.cBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки SerialPorts";
            // 
            // chBoxRtsEnable
            // 
            this.chBoxRtsEnable.AutoSize = true;
            this.chBoxRtsEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxRtsEnable.Location = new System.Drawing.Point(154, 189);
            this.chBoxRtsEnable.Name = "chBoxRtsEnable";
            this.chBoxRtsEnable.Size = new System.Drawing.Size(113, 20);
            this.chBoxRtsEnable.TabIndex = 11;
            this.chBoxRtsEnable.Text = "RTS ENABLE";
            this.chBoxRtsEnable.UseVisualStyleBackColor = true;
            this.chBoxRtsEnable.CheckedChanged += new System.EventHandler(this.chBoxRtsEnable_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnCLOSE);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(6, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblStatusCom);
            this.groupBox8.Location = new System.Drawing.Point(154, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(113, 100);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Статус RS232";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.BackColor = System.Drawing.Color.Red;
            this.lblStatusCom.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusCom.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblStatusCom.Location = new System.Drawing.Point(32, 46);
            this.lblStatusCom.Margin = new System.Windows.Forms.Padding(3);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(49, 23);
            this.lblStatusCom.TabIndex = 0;
            this.lblStatusCom.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 123);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Enabled = false;
            this.btnCLOSE.Location = new System.Drawing.Point(13, 67);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(116, 50);
            this.btnCLOSE.TabIndex = 1;
            this.btnCLOSE.Text = "Закрыть";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(11, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(118, 50);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxDtrEnable.Location = new System.Drawing.Point(24, 189);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(114, 20);
            this.chBoxDtrEnable.TabIndex = 10;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT NAME";
            // 
            // cBoxPARITYBITS
            // 
            this.cBoxPARITYBITS.FormattingEnabled = true;
            this.cBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxPARITYBITS.Location = new System.Drawing.Point(123, 141);
            this.cBoxPARITYBITS.Name = "cBoxPARITYBITS";
            this.cBoxPARITYBITS.Size = new System.Drawing.Size(140, 24);
            this.cBoxPARITYBITS.TabIndex = 4;
            this.cBoxPARITYBITS.Text = "None";
            // 
            // cBoxSTOPBITS
            // 
            this.cBoxSTOPBITS.FormattingEnabled = true;
            this.cBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxSTOPBITS.Location = new System.Drawing.Point(123, 111);
            this.cBoxSTOPBITS.Name = "cBoxSTOPBITS";
            this.cBoxSTOPBITS.Size = new System.Drawing.Size(140, 24);
            this.cBoxSTOPBITS.TabIndex = 3;
            this.cBoxSTOPBITS.Text = "One";
            // 
            // cBoxDATABITS
            // 
            this.cBoxDATABITS.FormattingEnabled = true;
            this.cBoxDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDATABITS.Location = new System.Drawing.Point(123, 81);
            this.cBoxDATABITS.Name = "cBoxDATABITS";
            this.cBoxDATABITS.Size = new System.Drawing.Size(140, 24);
            this.cBoxDATABITS.TabIndex = 2;
            this.cBoxDATABITS.Text = "8";
            // 
            // cBoxBAUDRATE
            // 
            this.cBoxBAUDRATE.AutoCompleteCustomSource.AddRange(new string[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBAUDRATE.FormattingEnabled = true;
            this.cBoxBAUDRATE.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cBoxBAUDRATE.Location = new System.Drawing.Point(123, 51);
            this.cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            this.cBoxBAUDRATE.Size = new System.Drawing.Size(140, 24);
            this.cBoxBAUDRATE.TabIndex = 1;
            this.cBoxBAUDRATE.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(123, 21);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(140, 24);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(6, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 25);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tBoxDataOut.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDataOut.ForeColor = System.Drawing.Color.Lime;
            this.tBoxDataOut.Location = new System.Drawing.Point(7, 15);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxDataOut.Size = new System.Drawing.Size(334, 30);
            this.tBoxDataOut.TabIndex = 4;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbDataINLength);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblDataOutLength);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Location = new System.Drawing.Point(310, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 162);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // lbDataINLength
            // 
            this.lbDataINLength.AutoSize = true;
            this.lbDataINLength.Location = new System.Drawing.Point(302, 135);
            this.lbDataINLength.Name = "lbDataINLength";
            this.lbDataINLength.Size = new System.Drawing.Size(21, 16);
            this.lbDataINLength.TabIndex = 8;
            this.lbDataINLength.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "IN:";
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Location = new System.Drawing.Point(221, 135);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(21, 16);
            this.lblDataOutLength.TabIndex = 1;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Колличество символов    OUT: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Controls.Add(this.btnClearData);
            this.groupBox4.Location = new System.Drawing.Point(10, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 84);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBoxWrite);
            this.groupBox6.Controls.Add(this.chBoxWriteLine);
            this.groupBox6.Location = new System.Drawing.Point(214, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(111, 75);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxWrite.Location = new System.Drawing.Point(0, 46);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(60, 20);
            this.chBoxWrite.TabIndex = 13;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxWriteLine.Location = new System.Drawing.Point(0, 17);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(88, 20);
            this.chBoxWriteLine.TabIndex = 12;
            this.chBoxWriteLine.Text = "Write Line";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxUsingEnter);
            this.groupBox5.Controls.Add(this.chBoxUsingButton);
            this.groupBox5.Location = new System.Drawing.Point(98, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 75);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // chBoxUsingEnter
            // 
            this.chBoxUsingEnter.AutoSize = true;
            this.chBoxUsingEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxUsingEnter.Location = new System.Drawing.Point(6, 46);
            this.chBoxUsingEnter.Name = "chBoxUsingEnter";
            this.chBoxUsingEnter.Size = new System.Drawing.Size(98, 20);
            this.chBoxUsingEnter.TabIndex = 13;
            this.chBoxUsingEnter.Text = "Using Enter";
            this.chBoxUsingEnter.UseVisualStyleBackColor = true;
            // 
            // chBoxUsingButton
            // 
            this.chBoxUsingButton.AutoSize = true;
            this.chBoxUsingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxUsingButton.Location = new System.Drawing.Point(6, 17);
            this.chBoxUsingButton.Name = "chBoxUsingButton";
            this.chBoxUsingButton.Size = new System.Drawing.Size(104, 20);
            this.chBoxUsingButton.TabIndex = 12;
            this.chBoxUsingButton.Text = "Using Button";
            this.chBoxUsingButton.UseVisualStyleBackColor = true;
            this.chBoxUsingButton.CheckedChanged += new System.EventHandler(this.chBoxUsingButton_CheckedChanged);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(6, 51);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(86, 24);
            this.btnClearData.TabIndex = 5;
            this.btnClearData.Text = "Очистить";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tBoxDataIN);
            this.groupBox9.Location = new System.Drawing.Point(310, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(340, 219);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tBoxDataIN.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDataIN.ForeColor = System.Drawing.Color.Lime;
            this.tBoxDataIN.Location = new System.Drawing.Point(6, 14);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ReadOnly = true;
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxDataIN.Size = new System.Drawing.Size(334, 199);
            this.tBoxDataIN.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 402);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "COM Port терминал";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPARITYBITS;
        private System.Windows.Forms.ComboBox cBoxSTOPBITS;
        private System.Windows.Forms.ComboBox cBoxDATABITS;
        private System.Windows.Forms.ComboBox cBoxBAUDRATE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.CheckBox chBoxRtsEnable;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxUsingEnter;
        private System.Windows.Forms.CheckBox chBoxUsingButton;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.Label lbDataINLength;
        private System.Windows.Forms.Label label7;
    }
}

