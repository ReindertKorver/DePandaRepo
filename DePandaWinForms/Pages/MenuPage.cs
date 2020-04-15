﻿using System;
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
                DescriptionMenuItemInput.Text = menuItem.Description;
                PriceMenuItemInput.Text = menuItem.Price.ToString();
                NameMenuItemInput.Text = menuItem.Name;
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
                NameMenuItemInput.Text = "";
                DescriptionMenuItemInput.Text = "";
                PriceMenuItemInput.Text = "";

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
            string PriceToComma = PriceMenuItemInput.Text.Replace('.', ',');
      
            if (ValidateInput("1234567890,", PriceToComma))
            {
                Console.WriteLine(PriceToComma);
                decimal Price = Convert.ToDecimal(PriceToComma);

                TempStockDishes.Add(new Dish() { Name = NameMenuItemInput.Text, Price = Price, Description = DescriptionMenuItemInput.Text });

                NameMenuItemInput.Text = "";
                DescriptionMenuItemInput.Text = "";
                PriceMenuItemInput.Text = "";

                LoadInMenuItems();
            }
            else
            {
                MessageBox.Show("U mag alleen cijfers invoeren");
            }
        }

        private bool ValidateInput(string mayContains, string input)
        {
            foreach(char c in input)
            {
                if(!mayContains.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void DeleteSelectedMenuItem(object sender, EventArgs e)
        {
            Dish menuItem = (Dish)MenuItemsList.SelectedItem;

            if (TempStockDishes.Count() >= 1)
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

            string PriceToComma = PriceMenuItemInput.Text.Replace('.', ',');

            if (ValidateInput("1234567890,", PriceToComma))
            {
                menuItem.Name = NameMenuItemInput.Text;
                menuItem.Price = Convert.ToDecimal(PriceToComma);
                menuItem.Description = DescriptionMenuItemInput.Text;
            }
            else
            {
                MessageBox.Show("U mag alleen cijfers cijfers invoeren");
            }
            
            LoadInMenuItems();
        }

        private void CloseMenuItemPanel(object sender, EventArgs e)
        {
            MenuItemGroupBox.Visible = false;
        }
    }
}