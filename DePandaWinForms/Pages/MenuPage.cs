using DePandaWinForms.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages
{
    public partial class MenuPage : FormDataProvider
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void Pincode_Click(object sender, EventArgs e)
        {
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            if (DataStorage?.storage?.StockDishes != null)
            {
                MenuGrid.DataSource = DataStorage.storage.StockDishes;
            }
            else if (DataStorage.storage.StockDishes == null)
            {
                DataStorage.storage.StockDishes = new List<DePandaLib.Entities.Dish>() {
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish1",
                    Price=2.5M
                },
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish2",
                    Price=2.5M
                },
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish3",
                    Price=2.5M
                },
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish4",
                    Price=2.5M
                },
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish5",
                    Price=2.5M
                },
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish6",
                    Price=2.5M
                },
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish7",
                    Price=2.5M
                },
                new DePandaLib.Entities.Dish() {
                    ID=Guid.NewGuid().ToString(),
                    Name="Dish8",
                    Price=2.5M
                },
            };
                MenuGrid.DataSource = DataStorage.storage.StockDishes;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (DataStorage?.storage?.StockDishes != null)
            {
                MenuGrid.DataSource = DataStorage.storage.StockDishes.Where(s => s.Name.ToLower().Contains(textBox1.Text.ToLower()));
            }
        }
    }
}