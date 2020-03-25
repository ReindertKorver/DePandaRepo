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
    public partial class Tafel : Form
    {
        public Tafel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((Panel)sender).Tag.ToString());
        }
    }
}