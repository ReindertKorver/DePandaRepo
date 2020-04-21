using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DePandaLib.Entities;

namespace DePandaWinForms.Design
{
    public partial class OrderItem : UserControl
    {
        public Dish DishItem { get; set; }

        private int count = 0;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                Counter.Text = count.ToString();
                DishItem.Amount = count;
            }
        }

        public event EventHandler OnAdd;

        public event EventHandler OnRemove;

        public OrderItem(Dish dish)
        {
            InitializeComponent();
            DishItem = dish;
            Item.Text = dish.Name;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Count++;
            OnAdd?.Invoke(this, EventArgs.Empty);
        }

        private void Min_Click(object sender, EventArgs e)
        {
            Count--;
            OnRemove?.Invoke(this, EventArgs.Empty);
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {
        }
    }
}