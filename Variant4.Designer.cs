namespace lab3
{
    partial class Variant_4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateForecast = new System.Windows.Forms.Button();
            this.btnCalculatePercents = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(728, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(27, 31);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(223, 37);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "извлечь данные";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(28, 117);
            this.numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(221, 22);
            this.numYear.TabIndex = 2;
            this.numYear.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "выбрать год";
            // 
            // btnCalculateForecast
            // 
            this.btnCalculateForecast.Location = new System.Drawing.Point(26, 168);
            this.btnCalculateForecast.Name = "btnCalculateForecast";
            this.btnCalculateForecast.Size = new System.Drawing.Size(223, 37);
            this.btnCalculateForecast.TabIndex = 4;
            this.btnCalculateForecast.Text = "вычислить прогноз";
            this.btnCalculateForecast.UseVisualStyleBackColor = true;
            this.btnCalculateForecast.Click += new System.EventHandler(this.btnCalculateForecast_Click);
            // 
            // btnCalculatePercents
            // 
            this.btnCalculatePercents.Location = new System.Drawing.Point(26, 213);
            this.btnCalculatePercents.Name = "btnCalculatePercents";
            this.btnCalculatePercents.Size = new System.Drawing.Size(223, 63);
            this.btnCalculatePercents.TabIndex = 5;
            this.btnCalculatePercents.Text = "вычислить максимальный процент роста и падения за год";
            this.btnCalculatePercents.UseVisualStyleBackColor = true;
            this.btnCalculatePercents.Click += new System.EventHandler(this.btnCalculatePercents_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(26, 300);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(544, 354);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(342, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(355, 108);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(612, 300);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(543, 354);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // Variant_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 666);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCalculatePercents);
            this.Controls.Add(this.btnCalculateForecast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Variant_4";
            this.Text = "Variant_4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateForecast;
        private System.Windows.Forms.Button btnCalculatePercents;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}