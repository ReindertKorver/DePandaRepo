using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DePandaLib.DAL;
using DePandaLib.Entities;

namespace DePandaWinForms.Pages
{
    public partial class StatisticsPage : Form
    {
        private List<Dish> ListOfDishes = DataStorageHandler.Storage.StockDishes;
        public StatisticsPage()
        {
            InitializeComponent();
            TotalItemsLabel.Text = $"Totaal aantal items: {SumAllItems()}";
        }

       private int SumAllItems()
        {
            int total = 0;
            foreach (Dish menuItem in ListOfDishes)
            {
                total += menuItem.Amount;
            }
            return total;
        }
        private void ShowDrinkGraph_Click(object sender, EventArgs e)
        {
            if (!ShowDrinkWithShotGraph.Visible)
            {
                ShowDrinkWithShotGraph.Visible = true;
                ShowDrinkWithOutShotGraph.Visible = true;
                DrinkWithAlcohol.Visible = true;
            }
            else
            {
                ShowDrinkWithShotGraph.Visible = false;
                ShowDrinkWithOutShotGraph.Visible = false;
                DrinkWithAlcohol.Visible = false;
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Fish.Visible)
            {
                vegetables.Visible = true;
                Fish.Visible = true;
                Meat.Visible = true;
            }
            else
            {
                vegetables.Visible = false;
                Fish.Visible = false;
                Meat.Visible = false;
            }
        }

        private void SetGraph() // catogorie indoen?
        {
            // eerst leeg maken
            foreach (var series in DrankMetPrinkChart.Series)
            {
                series.Points.Clear();
            }
            DrankMetPrinkChart.Visible = true;
            TotalItemsLabel.Visible = true;
            foreach (Dish menuItem in ListOfDishes)
            {
                this.DrankMetPrinkChart.Series["Hoeveelheid"].Points.AddXY(menuItem.Name, menuItem.Amount);
            }


        }

        private void ShowGraph(object sender, EventArgs e)
        {
            SetGraph();
        }
    }
}
