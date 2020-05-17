using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DePandaClassLib.Entities;
using DePandaLib.DAL;
using DePandaLib.Entities;

namespace DePandaWinForms.Pages
{
    public partial class StatisticsPage : Form
    {
        int total = 0;
        private List<Dish> ListOfDishes = DataStorageHandler.Storage.StockDishes;
        Dictionary<string, int> FromCategoryToEnum = new Dictionary<string, int>(){
                                  {"drankmetprik", 1}, {"drankzonderprik", 2},
                                  {"vlees", 3},{"vis", 4},
                                  {"groente", 5}, {"zuivel", 6},
                                  {"drankmetalcohol", 7},

        };
        public StatisticsPage()
        {
            InitializeComponent();
        }

       private int SumAllItems(string categorie)
        {
            
            foreach (Dish menuItem in ListOfDishes)
            {
                if (FromCategoryToEnum[categorie] == (int)menuItem.Category)
                    total += menuItem.Amount;
            }
            return total;
        }
        private void ShowDrinkGraph_Click(object sender, EventArgs e)
        {
            if (!ShowDrinksWithShots.Visible)
            {
                ShowDrinksWithShots.Visible = true;
                ShowDrinksWithoutShots.Visible = true;
                ShowDrinksWithAlcohol.Visible = true;
            }
            else
            {
                ShowDrinksWithShots.Visible = false;
                ShowDrinksWithoutShots.Visible = false;
                ShowDrinksWithAlcohol.Visible = false;
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ShowFish.Visible)
            {
                ShowVegtables.Visible = true;
                ShowFish.Visible = true;
                ShowMeat.Visible = true;
            }
            else
            {
                ShowVegtables.Visible = false;
                ShowFish.Visible = false;
                ShowMeat.Visible = false;
            }
        }

        private void SetGraph(string categorie) // catogorie indoen?
        {
            // eerst leeg maken
            DrankMetPrinkChart.Visible = true;
            TotalItemsLabel.Visible = true;
            foreach (var series in DrankMetPrinkChart.Series)
            {
                series.Points.Clear();
            }

            foreach (Dish menuItem in ListOfDishes)
            {
               if (FromCategoryToEnum[categorie] == (int)menuItem.Category)
                    this.DrankMetPrinkChart.Series["Hoeveelheid"].Points.AddXY(menuItem.Name, menuItem.Amount);
            }
            TotalItemsLabel.Text = $"Totaal aantal items: {SumAllItems(categorie)}";
        }
       
        private void ShowGraph(object sender, EventArgs e)
        {
            string categorie = ((sender as Button).Text).ToLower().Replace(" ", "");
            SetGraph(categorie);
        }
    }
}
