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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }
    }
}
