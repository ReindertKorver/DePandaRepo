namespace DePandaWinForms.Pages
{
    partial class StatisticsPage
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ShowDrinkGraph = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DrankMetPrinkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowDrinkWithShotGraph = new System.Windows.Forms.Button();
            this.ShowDrinkWithOutShotGraph = new System.Windows.Forms.Button();
            this.DrinkWithAlcohol = new System.Windows.Forms.Button();
            this.vegetables = new System.Windows.Forms.Button();
            this.Fish = new System.Windows.Forms.Button();
            this.Meat = new System.Windows.Forms.Button();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrankMetPrinkChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowDrinkGraph
            // 
            this.ShowDrinkGraph.BackColor = System.Drawing.Color.White;
            this.ShowDrinkGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDrinkGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowDrinkGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowDrinkGraph.Location = new System.Drawing.Point(12, 12);
            this.ShowDrinkGraph.Name = "ShowDrinkGraph";
            this.ShowDrinkGraph.Size = new System.Drawing.Size(162, 83);
            this.ShowDrinkGraph.TabIndex = 99;
            this.ShowDrinkGraph.Text = "geef\r\ndrank-statestieken\r\nweer";
            this.ShowDrinkGraph.UseVisualStyleBackColor = false;
            this.ShowDrinkGraph.Click += new System.EventHandler(this.ShowDrinkGraph_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 83);
            this.button1.TabIndex = 100;
            this.button1.Text = "geef\r\neet-statestieken\r\nweer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrankMetPrinkChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DrankMetPrinkChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DrankMetPrinkChart.Legends.Add(legend1);
            this.DrankMetPrinkChart.Location = new System.Drawing.Point(240, 238);
            this.DrankMetPrinkChart.Name = "DrankMetPrinkChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Hoeveelheid";
            this.DrankMetPrinkChart.Series.Add(series1);
            this.DrankMetPrinkChart.Size = new System.Drawing.Size(525, 300);
            this.DrankMetPrinkChart.TabIndex = 101;
            this.DrankMetPrinkChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Drank grafiek";
            this.DrankMetPrinkChart.Titles.Add(title1);
            this.DrankMetPrinkChart.Visible = false;
            // 
            // ShowDrinkWithShotGraph
            // 
            this.ShowDrinkWithShotGraph.BackColor = System.Drawing.Color.White;
            this.ShowDrinkWithShotGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDrinkWithShotGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowDrinkWithShotGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowDrinkWithShotGraph.Location = new System.Drawing.Point(240, 12);
            this.ShowDrinkWithShotGraph.Name = "ShowDrinkWithShotGraph";
            this.ShowDrinkWithShotGraph.Size = new System.Drawing.Size(162, 83);
            this.ShowDrinkWithShotGraph.TabIndex = 103;
            this.ShowDrinkWithShotGraph.Text = "drank met prik";
            this.ShowDrinkWithShotGraph.UseVisualStyleBackColor = false;
            this.ShowDrinkWithShotGraph.Visible = false;
            this.ShowDrinkWithShotGraph.MouseEnter += new System.EventHandler(this.ShowGraph);
            // 
            // ShowDrinkWithOutShotGraph
            // 
            this.ShowDrinkWithOutShotGraph.BackColor = System.Drawing.Color.White;
            this.ShowDrinkWithOutShotGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDrinkWithOutShotGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowDrinkWithOutShotGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowDrinkWithOutShotGraph.Location = new System.Drawing.Point(424, 12);
            this.ShowDrinkWithOutShotGraph.Name = "ShowDrinkWithOutShotGraph";
            this.ShowDrinkWithOutShotGraph.Size = new System.Drawing.Size(162, 83);
            this.ShowDrinkWithOutShotGraph.TabIndex = 104;
            this.ShowDrinkWithOutShotGraph.Text = "drank met prik";
            this.ShowDrinkWithOutShotGraph.UseVisualStyleBackColor = false;
            this.ShowDrinkWithOutShotGraph.Visible = false;
            this.ShowDrinkWithOutShotGraph.MouseEnter += new System.EventHandler(this.ShowGraph);
            // 
            // DrinkWithAlcohol
            // 
            this.DrinkWithAlcohol.BackColor = System.Drawing.Color.White;
            this.DrinkWithAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrinkWithAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DrinkWithAlcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.DrinkWithAlcohol.Location = new System.Drawing.Point(603, 12);
            this.DrinkWithAlcohol.Name = "DrinkWithAlcohol";
            this.DrinkWithAlcohol.Size = new System.Drawing.Size(162, 83);
            this.DrinkWithAlcohol.TabIndex = 105;
            this.DrinkWithAlcohol.Text = "drank met alcohol";
            this.DrinkWithAlcohol.UseVisualStyleBackColor = false;
            this.DrinkWithAlcohol.Visible = false;
            this.DrinkWithAlcohol.MouseEnter += new System.EventHandler(this.ShowGraph);
            // 
            // vegetables
            // 
            this.vegetables.BackColor = System.Drawing.Color.White;
            this.vegetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vegetables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.vegetables.Location = new System.Drawing.Point(240, 121);
            this.vegetables.Name = "vegetables";
            this.vegetables.Size = new System.Drawing.Size(162, 83);
            this.vegetables.TabIndex = 106;
            this.vegetables.Text = "groente";
            this.vegetables.UseVisualStyleBackColor = false;
            this.vegetables.Visible = false;
            this.vegetables.MouseEnter += new System.EventHandler(this.ShowGraph);
            // 
            // Fish
            // 
            this.Fish.BackColor = System.Drawing.Color.White;
            this.Fish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Fish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.Fish.Location = new System.Drawing.Point(424, 121);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(162, 83);
            this.Fish.TabIndex = 107;
            this.Fish.Text = "vis";
            this.Fish.UseVisualStyleBackColor = false;
            this.Fish.Visible = false;
            this.Fish.MouseEnter += new System.EventHandler(this.ShowGraph);
            // 
            // Meat
            // 
            this.Meat.BackColor = System.Drawing.Color.White;
            this.Meat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Meat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Meat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.Meat.Location = new System.Drawing.Point(603, 121);
            this.Meat.Name = "Meat";
            this.Meat.Size = new System.Drawing.Size(162, 83);
            this.Meat.TabIndex = 108;
            this.Meat.Text = "vlees";
            this.Meat.UseVisualStyleBackColor = false;
            this.Meat.Visible = false;
            this.Meat.MouseEnter += new System.EventHandler(this.ShowGraph);
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.BackColor = System.Drawing.Color.White;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalItemsLabel.Location = new System.Drawing.Point(605, 238);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(160, 17);
            this.TotalItemsLabel.TabIndex = 109;
            this.TotalItemsLabel.Text = "Totaal aantal items: 209";
            this.TotalItemsLabel.Visible = false;
            // 
            // StatisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 667);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.Meat);
            this.Controls.Add(this.Fish);
            this.Controls.Add(this.vegetables);
            this.Controls.Add(this.DrinkWithAlcohol);
            this.Controls.Add(this.ShowDrinkWithOutShotGraph);
            this.Controls.Add(this.ShowDrinkWithShotGraph);
            this.Controls.Add(this.DrankMetPrinkChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowDrinkGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsPage";
            this.Text = "StatisticsPage";
            ((System.ComponentModel.ISupportInitialize)(this.DrankMetPrinkChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowDrinkGraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart DrankMetPrinkChart;
        private System.Windows.Forms.Button ShowDrinkWithShotGraph;
        private System.Windows.Forms.Button ShowDrinkWithOutShotGraph;
        private System.Windows.Forms.Button DrinkWithAlcohol;
        private System.Windows.Forms.Button vegetables;
        private System.Windows.Forms.Button Fish;
        private System.Windows.Forms.Button Meat;
        private System.Windows.Forms.Label TotalItemsLabel;
    }
}