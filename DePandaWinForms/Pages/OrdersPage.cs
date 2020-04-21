using DePandaLib.Entities;
using DePandaWinForms.Design;
using DePandaWinForms.Pages.OrderPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages
{
    public partial class OrdersPage : Form
    {
        public Order CurrentOrder;

        public OrdersPage()
        {
            InitializeComponent();
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            CheckOrderAndContinue(NewOrder);
        }

        private void CheckOrderAndContinue(Action continueation)
        {
            if (CurrentOrder != null)
            {
                DialogResult res = MessageBox.Show("U bent al een bestelling aan het aanmaken/wijzigen, wilt u doorgaan zonder op te slaan?", "Let op!", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    continueation();
                }
            }
            else
            {
                continueation();
            }
        }

        public void NewOrder()
        {
            RightEditPanel.Controls.Clear();
            CurrentOrder = new Order();

            NewOrder newOrder = new NewOrder(ref CurrentOrder);
            newOrder.TopLevel = false;
            newOrder.Dock = DockStyle.Fill;
            RightEditPanel.Controls.Add(newOrder);
            newOrder.Show();
        }

        public void EditOrder()
        {
            if (CurrentOrder == null)
            {
                //Almost impossible
                MessageBox.Show("U hebt geen bestelling geselecteerd", "Let op!");
            }
            else
            {
                RightEditPanel.Controls.Clear();
                EditOrder editOrder = new EditOrder(ref CurrentOrder);
                editOrder.TopLevel = false;
                editOrder.Dock = DockStyle.Fill;
                RightEditPanel.Controls.Add(editOrder);
                editOrder.Show();
            }
        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOrderAndContinue(EditOrder);
        }
    }
}