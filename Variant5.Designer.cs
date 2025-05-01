namespace lab3
{
    partial class Variant5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonForecast = new System.Windows.Forms.Button();
            this.numericUpDownForecastYears = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForecastYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(393, 714);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Максимальное сокращение населения:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(393, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Максимальный прирост населения:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(384, 645);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 113);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Демографические данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(384, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Введите кол-во лет для прогноза:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(384, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "N:";
            // 
            // buttonForecast
            // 
            this.buttonForecast.Location = new System.Drawing.Point(384, 553);
            this.buttonForecast.Name = "buttonForecast";
            this.buttonForecast.Size = new System.Drawing.Size(504, 50);
            this.buttonForecast.TabIndex = 16;
            this.buttonForecast.Text = "Сделать прогноз";
            this.buttonForecast.UseVisualStyleBackColor = true;
            // 
            // numericUpDownForecastYears
            // 
            this.numericUpDownForecastYears.Location = new System.Drawing.Point(768, 513);
            this.numericUpDownForecastYears.Name = "numericUpDownForecastYears";
            this.numericUpDownForecastYears.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownForecastYears.TabIndex = 15;
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(424, 473);
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownN.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(337, 291);
            this.dataGridView1.TabIndex = 13;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(-104, -54);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(155, 50);
            this.buttonLoadData.TabIndex = 12;
            this.buttonLoadData.Text = "Загрузить данные";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Загрузить данные";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1100, 382);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // Variant5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 801);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonForecast);
            this.Controls.Add(this.numericUpDownForecastYears);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoadData);
            this.Name = "Variant5";
            this.Text = "Variant5";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForecastYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonForecast;
        private System.Windows.Forms.NumericUpDown numericUpDownForecastYears;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}