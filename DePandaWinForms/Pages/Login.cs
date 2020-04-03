using DePandaLib.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages
{
    public partial class Login : Form
    {
        public Login(bool Maxed)
        {
            InitializeComponent();
            if (Maxed)
            {
                this.WindowState = FormWindowState.Maximized;
            }
           
        }

        

        private bool closeHover = false;
        private bool maxHover = false;
        private bool minHover = false;
        public bool Maxed = false;
        private void LoginEvent()
        {
            if (PinInput.Text == DataStorageHandler.Storage.Settings.PinCode) // 00000
            {

                if (this.WindowState == FormWindowState.Maximized)
                {
                    Maxed = true;
                }

                this.Hide();
                Form mainScreen = new Form1(Maxed);
                mainScreen.Show();


            }
            else if (PinInput.Text.Length == DataStorageHandler.Storage.Settings.PinCode.Length && PinInput.Text != DataStorageHandler.Storage.Settings.PinCode)
            {

                MessageBox.Show("U heeft een verkeerde pincode ingevuld");
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginEvent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        public void Close_MouseHover(object sender, EventArgs e)
        {
            Close.Image = (!closeHover) ? DePandaWinForms.Properties.Resources.closehover : DePandaWinForms.Properties.Resources.close;
            closeHover = !closeHover;
        }
        private void Maximize_MouseHover(object sender, EventArgs e)
        {
            Maximize.Image = (!maxHover) ? DePandaWinForms.Properties.Resources.maxhover : DePandaWinForms.Properties.Resources.max;
            maxHover = !maxHover;
        }
        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.Image = (!minHover) ? DePandaWinForms.Properties.Resources.minhover : DePandaWinForms.Properties.Resources.min;
            minHover = !minHover;
        }


        public void ChangeWinState()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            ChangeWinState();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            ChangeWinState(); 
            
        }

        private void PinInput_TextChanged(object sender, EventArgs e)
        {
            LoginEvent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
    }
}