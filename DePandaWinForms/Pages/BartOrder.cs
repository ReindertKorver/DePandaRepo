using DePandaLib.DAL;
using DePandaLib.Entities;
using DePandaWinForms.Design;
using DePandaWinForms.Pages.OrderPage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages
{
    public partial class BartOrder : Form
    {
        public Order CurrentOrder;
        public BartOrder()
        {
            InitializeComponent();
            
            FillList();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            MakeOrder();
        }
        private void FillList()
        {
            List<Order> orders = DataStorageHandler.Storage.GetAllOrders();
            if (orders != null && orders.Count != 0)
            {
                List<OrderItem> items = new List<OrderItem>();
                foreach (var order in orders)
                {
                    OrderItem item = new OrderItem(order);
                    item.Size = new Size(ListOfTables.Size.Width - 23, 50);
                    item.UseCounter = false;
                    items.Add(item);
                }

                ListOfTables.Controls.Clear();
                ListOfTables.Controls.AddRange(items.ToArray());
            }
        }
        public void MakeOrder()
        {
            RightPanel.Controls.Clear();

            NewOrder newOrder = new NewOrder(ref CurrentOrder);
            newOrder.TopLevel = false;
            newOrder.Dock = DockStyle.Fill;
            RightPanel.Controls.Add(newOrder);
            newOrder.OrderSaved += MakeOrderClose;
            newOrder.Show();
        }
        private void MakeOrderClose(object sender, EventArgs e)
        {
            var form = ((NewOrder)sender);
            //Clear the listener so the garbagecollector can collect it
            form.OrderSaved -= MakeOrderClose;
            form.Hide();
            form = null;
            CurrentOrder = null;
            FillList();
        }
        private void SearchBoxEnter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";        
        }

        private void SearchBoxLeave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "Zoeken";
        }
    }
    
}
