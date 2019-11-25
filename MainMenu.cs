using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheCoffeeBeans
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {

            SelectLevel selectLevel = new SelectLevel();
            selectLevel.Show();
            this.Hide();
            
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }
    }
}
