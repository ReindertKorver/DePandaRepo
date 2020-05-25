using DePandaLib.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages.OrderPage
{
    public partial class PaymentOption : Form
    {
        public PaymentOption(Order CurrentOrder)
        {
            InitializeComponent();
            decimal total = CurrentOrder.GetTotal();
            TotalOrderAmount.Text = total.ToString();
            ProgressBar.Location = new Point(6, 41);
            ProgressText.Location = new Point(3, 12);
            ProgressPanel.Location = new Point(306, 159);
        }

        private void PinButton_Click(object sender, EventArgs e)
        {
            Timer.Start();
            Show("Pin");
        }

        private void Show(string Show)
        {
            Question.Visible = false;
            CashButton.Visible = false;
            PinButton.Visible = false;
            if (Show == "Pin")
            {
                ProgressText.Visible = true;
                ProgressBar.Visible = true;
                ProgressPanel.Visible = true;
            }
            if (Show == "Cash")
            {
                CustomerGivesLabel.Visible = true;
                TotalGivenAmountBox.Visible = true;
                ChangeLabel.Visible = true;
                ContactPanel.Visible = true;
                OutPutTextBox.Visible = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (ProgressBar.Value == 100)
            {
                Timer.Stop();
                this.Close();
                MessageBox.Show("Betaling is gelukt");
            }
            else
            {
                ProgressBar.Increment(3);
            }
        }
        private void TotalGivenAmountBox_TextChanged(object sender, EventArgs e)
        {
            string AmountGivenString = (sender as TextBox).Text;
            string PuntNaarComma = AmountGivenString.Replace(".", ",");
            if (Decimal.TryParse(PuntNaarComma, out decimal CorrectAmountGiven))
            {
                decimal TotalOrder = Decimal.Parse(TotalOrderAmount.Text);
                OutPutTextBox.Text = (TotalOrder - CorrectAmountGiven).ToString();
            }
            else
            {
                (sender as TextBox).Text = "";
            }
        }



        private void CashButton_Click(object sender, EventArgs e)
        {
            Show("Cash");
        }

        private void ConfirmCashPayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
