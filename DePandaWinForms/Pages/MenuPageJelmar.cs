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
        public MenuPageJelmar()
        {
            InitializeComponent();
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        List<string> listcollection = new List<string>();
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                foreach (string str in listcollection)
                {
                    if (str.StartsWith(textBox1.Text))
                    {
                        //flowLayoutPanel1.
                    }
                }
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
            Dish dish = new Dish();
            dish.Name = NieuwMenuItemTekstbox.Text;
            dish.Price = Convert.ToDecimal(PrijsInput.Text);
            DataStorageHandler.Storage.StockDishes.Add(dish);
            panel1.Visible = false;
        }
    }
}