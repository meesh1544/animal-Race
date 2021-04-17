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
    public partial class Instructions_and_Rules : Form
    {
       
        public Instructions_and_Rules()
        {
            InitializeComponent();
        }

        private void backToOpeningScreen(object sender, EventArgs e)
        {
            this.Hide();
            Opening_Screen frm = new Opening_Screen();
            frm.Show();




            

            }

        
    }
    }
