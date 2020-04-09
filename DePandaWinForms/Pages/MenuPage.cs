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
using DePandaLib.Entities;

using System.Globalization;

namespace DePandaWinForms.Pages
{
    public partial class MenuPage : Form
    {
        private List<Dish> TempStockDishes;

        public MenuPage()
        {
            InitializeComponent();
            LoadInMenuItems();
        }

        public void LoadInMenuItems()
        {
            TempStockDishes = DataStorageHandler.Storage.StockDishes;

            foreach (Dish menuItem in TempStockDishes)
            {
                MenuItemsList.Items.Add(menuItem);
            }

            Console.WriteLine("hoi");
            MenuItemsList.ValueMember = "ID";
            MenuItemsList.DisplayMember = "Name";
        }

        public void CreateCommitOne()
        {

        }

        public void CreateCommitTwo()
        {

        }

        private void ShowCreateMenuItemPanel_Click(object sender, EventArgs e)
        {
            if (NewMenuItemGroupBox.Visible == false)
            {
                NewMenuItemGroupBox.Visible = true;
            }
            else
            {
                Console.WriteLine("hoi");
                NewMenuItemGroupBox.Visible = false;
            }
        }

        private void CreateNewMenuItem_Click(object sender, EventArgs e)
        {
            if (NewMenuItemGroupBox.Visible == true)
            {
                CultureInfo cultures = new CultureInfo("en-US");

                decimal Price = Convert.ToDecimal(PriceNewMenuItemInput.Text, cultures);

                TempStockDishes.Add(new Dish() { Name = NameNewMenuItemInput.Text, Price = Price, Description = DescriptionNewMenuItemInput.Text });

                MenuItemsList.Items.Clear();

                LoadInMenuItems();
            }
        }

        private void SearchMenuItems(object sender, EventArgs e)
        {
            MenuItemsList.Items.Clear();

            if (SearchMenuItemsList.Text.Length > 0)
            {
                foreach (var menuItem in TempStockDishes)
                {
                    if (menuItem.Name.ToLower().Contains(SearchMenuItemsList.Text.ToLower()))
                    {
                        MenuItemsList.Items.Add(menuItem.Name);
                    }
                }
            }
            else
            {
                LoadInMenuItems();
            }
        }

        private void MenuItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMenuItemText.Visible = true;

            Dish menuItem = MenuItemsList.SelectedItem as Dish;

            DescriptionSelectedMenuItem.Text = menuItem.Description;
            PriceSelectedMenuItem.Text = menuItem.Price.ToString();
            NameSelectedMenuItem.Text = menuItem.Name;
        }

        private void CloseSelectedMenuItem_Click(object sender, EventArgs e)
        {
            SelectedMenuItemText.Visible = false;
        }
    }
}