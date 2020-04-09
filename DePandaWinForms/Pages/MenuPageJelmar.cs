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
    public partial class MenuPageJelmar : Form
    {
        string SelectedMenuItemId;
        public MenuPageJelmar()
        {
            InitializeComponent();
            FillMenuItemList();
        }

        private void FillMenuItemList()
        {
            MenuItemList.Controls.Clear();
            foreach (Dish dish in DataStorageHandler.Storage.StockDishes)
            {
                Button btn = new Button();
                btn.Text = dish.Name;
                btn.Tag = dish;
                btn.Size = new System.Drawing.Size(MenuItemList.Size.Width - 25, 63);
                btn.Click += new System.EventHandler(this.MenuItemClick);
                MenuItemList.Controls.Add(btn);
            }
        }
        private void MenuItemClick(object sender, EventArgs e)
        {
            var dish = (sender as Button).Tag as Dish;
            Console.WriteLine(dish.Price);
            panel1.Visible = true;
            NieuwMenuItemTekstbox.Text = dish.Name;
            PrijsInput.Text = dish.Price.ToString();
            NotitiesInput.Text = dish.Description;
            SelectedMenuItemId = dish.ID;
        }

        private void NieuwMenuItemClick(object sender, EventArgs e)
        {
            panel1.Visible = true;
            SelectedMenuItemId = null;
            NieuwMenuItemTekstbox.Text = "Nieuw menu item";
            PrijsInput.Text = "";
            NotitiesInput.Text = "";
        }

        private void SearchBoxFlowPanel_TextChanged(object sender, EventArgs e)
        {
            var searchDishes = DataStorageHandler.Storage.StockDishes.Where(dish => dish.Name.ToLower().Contains(Searchbox.Text.ToLower()));
            MenuItemList.Controls.Clear();
            foreach (Dish dish in searchDishes)
            {
                Button btn = new Button();
                btn.Text = dish.Name;
                btn.Tag = dish;
                btn.Size = new System.Drawing.Size(MenuItemList.Size.Width - 25, 63);
                btn.Click += new System.EventHandler(this.MenuItemClick);
                MenuItemList.Controls.Add(btn);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (NieuwMenuItemTekstbox.Text == "Nieuw menu item")
            {
                NieuwMenuItemTekstbox.Text = "";
                NieuwMenuItemTekstbox.ForeColor = Color.Black;
            }
        }

        private void OpslaanButton_Click(object sender, EventArgs e)
        {
            if (SelectedMenuItemId == null)
            {
                Dish dish = new Dish();
                dish.Name = NieuwMenuItemTekstbox.Text;
                dish.Price = Convert.ToDecimal(PrijsInput.Text);
                dish.Description = NotitiesInput.Text;
                DataStorageHandler.Storage.StockDishes.Add(dish);
            }
            else
            {
                Dish dish = DataStorageHandler.Storage.StockDishes.Where(d => d.ID == SelectedMenuItemId).FirstOrDefault();
                dish.Name = NieuwMenuItemTekstbox.Text;
                dish.Price = Convert.ToDecimal(PrijsInput.Text);
                dish.Description = NotitiesInput.Text;
            }
            panel1.Visible = false;
            FillMenuItemList();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (SelectedMenuItemId != null)
            {
                DataStorageHandler.Storage.StockDishes.RemoveAll(dish => dish.ID == SelectedMenuItemId);
            }
        }
    }
}