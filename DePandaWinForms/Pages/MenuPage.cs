using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DePandaLib.DAL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DePandaLib.Entities;

using System.Globalization;


namespace DePandaWinForms.Pages
{
    public partial class MenuPage : Form
    {

        DataStorageHandler dataStorageHandler = new DataStorageHandler();


        public MenuPage()
        {
            InitializeComponent();
            LoadInMenuItems();
        }

        public void LoadInMenuItems()
        {
            var MenuItems = DataStorageHandler.Storage.StockDishes;

            foreach (var menuItem in MenuItems)
            {
                MenuItemsList.Items.Add(menuItem.Name);
                Console.WriteLine(menuItem.Name);
            }
        }

        private void Pincode_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            CultureInfo cultures = new CultureInfo("en-US");

            decimal Price = Convert.ToDecimal(PriceInput.Text, cultures);

            DataStorageHandler.Storage.StockDishes.Add(new DePandaLib.Entities.Dish() { Name = NameInput.Text, Price = Price });

            MenuItemsList.Items.Clear();

            LoadInMenuItems();
            DataStorageHandler.SaveChanges();
        }
    }
}