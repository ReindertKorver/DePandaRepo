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
        public MenuPage()
        {
            InitializeComponent();

            List<Dish> dishes = new List<Dish>();

            //DataStorageHandler.Storage.StockDishes;



        }

        private void Pincode_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }



    }
}