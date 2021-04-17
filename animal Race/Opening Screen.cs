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
    public partial class Opening_Screen : Form
    {
        
        public Opening_Screen()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Frog1 gameWindow = new Frog1();
               
            gameWindow.Show();

        }

        private void InstructionsAndRules(object sender, EventArgs e)
        {

            Frog1 gameWindow = new Frog1();

            gameWindow.Show();
        }

        private void viewInstructionsAndRules(object sender, EventArgs e)
        {
            Instructions_and_Rules gameWindow = new Instructions_and_Rules();
            gameWindow.Show();
        }
    }
}
