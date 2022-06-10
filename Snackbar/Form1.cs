using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snackbar
{
    public partial class Form1 : Form
    {
        private Snack hambuger;
        private Snack frites;
        private Snack nuggets;

        public Form1()
        {
            InitializeComponent();
            hambuger = new Snack("Hamburger", 2, true, 20);
            frites = new Snack("Frites", 1, true, 15);
            nuggets = new Snack("Nuggets", 1.3, false, 15);

        }

        private void btnSnackInfo_Click(object sender, EventArgs e)
        {
            lbSnack1Info.Text = hambuger.GetInfo();
            lbSnack2Info.Text = frites.GetInfo();
            lbSnack3Info.Text = nuggets.GetInfo();
        }

        private void btnAddToShoppingCar_Click(object sender, EventArgs e)
        {
            


        }

    }
}
