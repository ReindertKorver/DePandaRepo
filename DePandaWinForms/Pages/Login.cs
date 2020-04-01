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
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PinInput.Text == DataStorageHandler.Storage.Settings.PinCode) // 00000
            {
                this.Hide();
                Form mainScreen = new Form1();
                mainScreen.Show();
            };
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

        private void Maximize_Click(object sender, EventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {

        }
    }
}