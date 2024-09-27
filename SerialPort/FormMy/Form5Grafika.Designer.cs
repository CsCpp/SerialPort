namespace SerialPortC

{
    partial class Form5Grafika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2I = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4U = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2I
            // 
            this.label2I.AutoSize = true;
            this.label2I.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2I.Location = new System.Drawing.Point(6, 16);
            this.label2I.Name = "label2I";
            this.label2I.Size = new System.Drawing.Size(66, 33);
            this.label2I.TabIndex = 1;
            this.label2I.Text = "000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4U);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(148, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 60);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label4U
            // 
            this.label4U.AutoSize = true;
            this.label4U.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4U.Location = new System.Drawing.Point(6, 16);
            this.label4U.Name = "label4U";
            this.label4U.Size = new System.Drawing.Size(66, 33);
            this.label4U.TabIndex = 1;
            this.label4U.Text = "000";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Location = new System.Drawing.Point(12, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 219);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "I/U";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea8.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea8.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX2.TitleForeColor = System.Drawing.Color.Gray;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea8.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisY.TitleForeColor = System.Drawing.Color.Gray;
            chartArea8.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea8.AxisY2.TitleForeColor = System.Drawing.Color.Gray;
            chartArea8.BackColor = System.Drawing.Color.Black;
            chartArea8.BorderColor = System.Drawing.Color.Gray;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Color = System.Drawing.Color.Red;
            series15.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series15.IsVisibleInLegend = false;
            series15.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series15.Legend = "Legend1";
            series15.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series15.MarkerColor = System.Drawing.Color.Red;
            series15.MarkerSize = 4;
            series15.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series15.Name = "I";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series16.IsVisibleInLegend = false;
            series16.Legend = "Legend1";
            series16.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series16.MarkerBorderWidth = 2;
            series16.MarkerColor = System.Drawing.Color.Blue;
            series16.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series16.Name = "U";
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(368, 200);
            this.chart1.TabIndex = 0;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10 sek",
            "1 min",
            "10 min",
            "30 min ",
            "1 hour",
            "1 day"});
            this.comboBox1.Location = new System.Drawing.Point(289, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2I);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Form5Grafika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(395, 300);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(395, 300);
            this.Name = "Form5Grafika";
            this.Text = "VoltAmpetr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5Grafika_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2I;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4U;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}