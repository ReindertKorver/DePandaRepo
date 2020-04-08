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

namespace DePandaWinForms.Pages
{
    public partial class MenuPageJelmar : Form
    {
        public MenuPageJelmar()
        {
            InitializeComponent();
        }

        private void Pincode_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
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

    }
}