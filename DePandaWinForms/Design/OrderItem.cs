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
        public Order Order { get; set; }
        public bool UseCounter { get; set; } = true;
        private int count = 0;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                Counter.Text = count.ToString();
                if (DishItem != null)
                    DishItem.Amount = count;
            }
        }

        public event EventHandler OnAdd;

        public event EventHandler OnRemove;

        public OrderItem()
        {
            InitializeComponent();
            Counter.Visible = UseCounter;
            Plus.Visible = UseCounter;
            Min.Visible = UseCounter;
        }

        public OrderItem(object obj, bool useDefaultAmount = false)
        {
            InitializeComponent();

            if (obj is Dish)
            {
                DishItem = (Dish)obj;
                Item.Text = DishItem.Name;
                if (useDefaultAmount)
                    Count = DishItem.Amount;
                else
                    DishItem.Amount = 0;
            }
            if (obj is Order)
            {
                UseCounter = false;
                Order = (Order)obj;
                if (Order.Reservation != null)
                    if (Order.Reservation.Date != null)
                        if (Order.Reservation.Table != null)
                            Item.Text = Order.OrderDate.ToString("HH:mm") + " Tafel: " + Order.Reservation.Table;
            }
            Counter.Visible = UseCounter;
            Plus.Visible = UseCounter;
            Min.Visible = UseCounter;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Count++;
            OnAdd?.Invoke(this, EventArgs.Empty);
        }

        private void Min_Click(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                Count--;
                OnRemove?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void OrderItem_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.Gray, 0.00f)), 0, 0, this.Width - 3, this.Height - 1, 10);
        }
    }
}