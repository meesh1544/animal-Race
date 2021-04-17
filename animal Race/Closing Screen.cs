using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animal_Race
{
    public partial class Closing_Screen : Form
    {
        public Closing_Screen()
        {
            InitializeComponent();
        }

        private void closingScreen(object sender, EventArgs e)
        {
            Frog1 closingScreen = new Frog1();

            closingScreen.Show();
        }
    }
}
