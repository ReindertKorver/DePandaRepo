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
            MenuItemsList.Items.Clear();

            foreach (Dish menuItem in TempStockDishes)
            {
                MenuItemsList.Items.Add(menuItem);
            }

            MenuItemsList.ValueMember = "ID";
            MenuItemsList.DisplayMember = "Name";
        }

        private void MenuItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateNewMenuItem.Visible = false;
            MenuItemGroupBox.Visible = true;

            Dish menuItem = (Dish)MenuItemsList.SelectedItem;

            if (menuItem == null)
            {
                MenuItemGroupBox.Visible = false;
            }
            else
            {
                DescriptionNewMenuItemInput.Text = menuItem.Description;
                PriceNewMenuItemInput.Text = menuItem.Price.ToString();
                NameNewMenuItemInput.Text = menuItem.Name;
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

        private void ShowMenuItemPanel(object sender, EventArgs e)
        {
            if (MenuItemGroupBox.Visible)
            {
                NameNewMenuItemInput.Text = "";
                DescriptionNewMenuItemInput.Text = "";
                PriceNewMenuItemInput.Text = "";

                CreateNewMenuItem.Visible = true;
            }
            else
            {
                if (MenuItemGroupBox.Visible == false)
                {
                    MenuItemGroupBox.Visible = true;
                }
                else
                {
                    MenuItemGroupBox.Visible = false;
                }
            }
        }

        private void CreateMenuItem(object sender, EventArgs e)
        {
            decimal Price = Convert.ToDecimal(PriceNewMenuItemInput.Text);

            TempStockDishes.Add(new Dish() { Name = NameNewMenuItemInput.Text, Price = Price, Description = DescriptionNewMenuItemInput.Text });

            NameNewMenuItemInput.Text = "";
            DescriptionNewMenuItemInput.Text = "";
            PriceNewMenuItemInput.Text = "";

            LoadInMenuItems();
        }

        private void CloseMenuItemPanel(object sender, EventArgs e)
        {
            MenuItemGroupBox.Visible = false;
        }
       
        private void DeleteSelectedMenuItem(object sender, EventArgs e)
        {
            Dish menuItem = (Dish)MenuItemsList.SelectedItem;

            if(TempStockDishes.Count() >= 1)
            {
                TempStockDishes.RemoveAll(item => item.ID == menuItem.ID);
                MenuItemGroupBox.Visible = false;
                MenuItemsList.SelectedItem = false;
                LoadInMenuItems();
            }  
        }

        private void EditSelectedMenuItem(object sender, EventArgs e)
        {
            Dish menuItem = (Dish)MenuItemsList.SelectedItem;


        }

       
    }
}