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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ShowDrinkGraph = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DrankMetPrinkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowDrinksWithShots = new System.Windows.Forms.Button();
            this.ShowDrinksWithoutShots = new System.Windows.Forms.Button();
            this.ShowDrinksWithAlcohol = new System.Windows.Forms.Button();
            this.ShowVegtables = new System.Windows.Forms.Button();
            this.ShowFish = new System.Windows.Forms.Button();
            this.ShowMeat = new System.Windows.Forms.Button();
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
            chartArea2.Name = "ChartArea1";
            this.DrankMetPrinkChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DrankMetPrinkChart.Legends.Add(legend2);
            this.DrankMetPrinkChart.Location = new System.Drawing.Point(245, 270);
            this.DrankMetPrinkChart.Name = "DrankMetPrinkChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Hoeveelheid";
            this.DrankMetPrinkChart.Series.Add(series2);
            this.DrankMetPrinkChart.Size = new System.Drawing.Size(525, 300);
            this.DrankMetPrinkChart.TabIndex = 101;
            this.DrankMetPrinkChart.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Drank grafiek";
            this.DrankMetPrinkChart.Titles.Add(title2);
            this.DrankMetPrinkChart.Visible = false;
            // 
            // ShowDrinksWithShots
            // 
            this.ShowDrinksWithShots.BackColor = System.Drawing.Color.White;
            this.ShowDrinksWithShots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDrinksWithShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowDrinksWithShots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowDrinksWithShots.Location = new System.Drawing.Point(245, 12);
            this.ShowDrinksWithShots.Name = "ShowDrinksWithShots";
            this.ShowDrinksWithShots.Size = new System.Drawing.Size(162, 83);
            this.ShowDrinksWithShots.TabIndex = 103;
            this.ShowDrinksWithShots.Text = "drank met prik";
            this.ShowDrinksWithShots.UseVisualStyleBackColor = false;
            this.ShowDrinksWithShots.Visible = false;
            this.ShowDrinksWithShots.Click += new System.EventHandler(this.ShowGraph);
            // 
            // ShowDrinksWithoutShots
            // 
            this.ShowDrinksWithoutShots.BackColor = System.Drawing.Color.White;
            this.ShowDrinksWithoutShots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDrinksWithoutShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowDrinksWithoutShots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowDrinksWithoutShots.Location = new System.Drawing.Point(429, 12);
            this.ShowDrinksWithoutShots.Name = "ShowDrinksWithoutShots";
            this.ShowDrinksWithoutShots.Size = new System.Drawing.Size(162, 83);
            this.ShowDrinksWithoutShots.TabIndex = 104;
            this.ShowDrinksWithoutShots.Text = "drank zonder prik";
            this.ShowDrinksWithoutShots.UseVisualStyleBackColor = false;
            this.ShowDrinksWithoutShots.Visible = false;
            this.ShowDrinksWithoutShots.Click += new System.EventHandler(this.ShowGraph);
            // 
            // ShowDrinksWithAlcohol
            // 
            this.ShowDrinksWithAlcohol.BackColor = System.Drawing.Color.White;
            this.ShowDrinksWithAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDrinksWithAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowDrinksWithAlcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowDrinksWithAlcohol.Location = new System.Drawing.Point(608, 12);
            this.ShowDrinksWithAlcohol.Name = "ShowDrinksWithAlcohol";
            this.ShowDrinksWithAlcohol.Size = new System.Drawing.Size(162, 83);
            this.ShowDrinksWithAlcohol.TabIndex = 105;
            this.ShowDrinksWithAlcohol.Text = "drank met alcohol";
            this.ShowDrinksWithAlcohol.UseVisualStyleBackColor = false;
            this.ShowDrinksWithAlcohol.Visible = false;
            this.ShowDrinksWithAlcohol.Click += new System.EventHandler(this.ShowGraph);
            // 
            // ShowVegtables
            // 
            this.ShowVegtables.BackColor = System.Drawing.Color.White;
            this.ShowVegtables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowVegtables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowVegtables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowVegtables.Location = new System.Drawing.Point(245, 121);
            this.ShowVegtables.Name = "ShowVegtables";
            this.ShowVegtables.Size = new System.Drawing.Size(162, 83);
            this.ShowVegtables.TabIndex = 106;
            this.ShowVegtables.Text = "groente";
            this.ShowVegtables.UseVisualStyleBackColor = false;
            this.ShowVegtables.Visible = false;
            this.ShowVegtables.Click += new System.EventHandler(this.ShowGraph);
            // 
            // ShowFish
            // 
            this.ShowFish.BackColor = System.Drawing.Color.White;
            this.ShowFish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowFish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowFish.Location = new System.Drawing.Point(429, 121);
            this.ShowFish.Name = "ShowFish";
            this.ShowFish.Size = new System.Drawing.Size(162, 83);
            this.ShowFish.TabIndex = 107;
            this.ShowFish.Text = "vis";
            this.ShowFish.UseVisualStyleBackColor = false;
            this.ShowFish.Visible = false;
            this.ShowFish.Click += new System.EventHandler(this.ShowGraph);
            // 
            // ShowMeat
            // 
            this.ShowMeat.BackColor = System.Drawing.Color.White;
            this.ShowMeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowMeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ShowMeat.Location = new System.Drawing.Point(608, 121);
            this.ShowMeat.Name = "ShowMeat";
            this.ShowMeat.Size = new System.Drawing.Size(162, 83);
            this.ShowMeat.TabIndex = 108;
            this.ShowMeat.Text = "vlees";
            this.ShowMeat.UseVisualStyleBackColor = false;
            this.ShowMeat.Visible = false;
            this.ShowMeat.Click += new System.EventHandler(this.ShowGraph);
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.BackColor = System.Drawing.Color.White;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalItemsLabel.Location = new System.Drawing.Point(610, 281);
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
            this.Controls.Add(this.ShowMeat);
            this.Controls.Add(this.ShowFish);
            this.Controls.Add(this.ShowVegtables);
            this.Controls.Add(this.ShowDrinksWithAlcohol);
            this.Controls.Add(this.ShowDrinksWithoutShots);
            this.Controls.Add(this.ShowDrinksWithShots);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowDrinkGraph);
            this.Controls.Add(this.DrankMetPrinkChart);
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
        private System.Windows.Forms.Button ShowDrinksWithShots;
        private System.Windows.Forms.Button ShowDrinksWithoutShots;
        private System.Windows.Forms.Button ShowDrinksWithAlcohol;
        private System.Windows.Forms.Button ShowVegtables;
        private System.Windows.Forms.Button ShowFish;
        private System.Windows.Forms.Button ShowMeat;
        private System.Windows.Forms.Label TotalItemsLabel;
    }
}