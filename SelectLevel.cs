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
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
        }

        private void easy_Click(object sender, EventArgs e)
        {
            Play play = new Play();
            play.Show();
            this.Hide();
        }

        private void medium_Click(object sender, EventArgs e)
        {
            MediumLevel mediumLevel = new MediumLevel();
            mediumLevel.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            HardLevel hardLevel = new HardLevel();
            hardLevel.Show();
            this.Hide();
        }
    }
}
