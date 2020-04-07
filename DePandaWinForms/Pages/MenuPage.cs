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
            }
        }

        private void Pincode_Click(object sender, EventArgs e)
        {
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
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
                NewMenuItemGroupBox.Visible = false;
            }

        
        }

        private void CreateNewMenuItem_Click(object sender, EventArgs e)
        {
            if (NewMenuItemGroupBox.Visible == true)
            {
                CultureInfo cultures = new CultureInfo("en-US");

                decimal Price = Convert.ToDecimal(PriceNewMenuItemInput.Text, cultures);

                DataStorageHandler.Storage.StockDishes.Add(new DePandaLib.Entities.Dish() { Name = NameNewMenuItemInput.Text, Price = Price, Description = DescriptionNewMenuItemInput.Text });

                MenuItemsList.Items.Clear();

                LoadInMenuItems();
                DataStorageHandler.SaveChanges();
            }
        }

       
        private void SearchMenuItems(object sender, EventArgs e)
        {
            var MenuItems = DataStorageHandler.Storage.StockDishes;

            MenuItemsList.Items.Clear();

            if(SearchMenuItemsList.Text.Length > 0)
            {
                foreach (var menuItem in MenuItems)
                {
                    if(menuItem.Name.ToLower().Contains(SearchMenuItemsList.Text.ToLower()))
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
            var MenuItems = DataStorageHandler.Storage.StockDishes;

            foreach (var menuItem in MenuItems)
            {
                if(menuItem.Name == MenuItemsList.SelectedItem) 
                {
                    SelectedMenuItemText.Visible = true;
                    
                    DescriptionSelectedMenuItem.Text = menuItem.Description;
                    PriceSelectedMenuItem.Text = menuItem.Price.ToString();
                    NameSelectedMenuItem.Text = menuItem.Name;
                }
            }
        }

        private void CloseSelectedMenuItem_Click(object sender, EventArgs e)
        {
            SelectedMenuItemText.Visible = false;
        }
    }
}