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
            int numberSnack1 = Convert.ToInt32(nSnack1.Value);
            int numberSnack2 = Convert.ToInt32(nSnack2.Value);
            int numberSnack3 = Convert.ToInt32(nSnack3.Value);

            lbSnack1Amount.Text = $"{numberSnack1}  {hambuger.Name}: ";
            lbSnack2Amount.Text = $"{numberSnack2}  {frites.Name}: ";
            lbSnack3Amount.Text = $"{numberSnack3}  {nuggets.Name}:";

            hambuger.SellSome(numberSnack1);
            frites.SellSome(numberSnack2);
            nuggets.SellSome(numberSnack3);

            double Snack1Price = hambuger.CalculateSnack(numberSnack1);
            double Snack2Price = frites.CalculateSnack(numberSnack2);
            double Snack3Price = nuggets.CalculateSnack(numberSnack3);
            double TotalPrice = Snack1Price + Snack2Price + Snack3Price;

            lbSnack1Cal.Text = $"Euro {Snack1Price}";
            lbSnack2Cal.Text = $"Euro {Snack2Price}";
            lbSnack3Cal.Text = $"Euro {Snack3Price}";
            lbTotalPrice.Text = $"Euro {TotalPrice}";

            lbSnack1Info.Text = hambuger.GetInfo();
            lbSnack2Info.Text = frites.GetInfo();
            lbSnack3Info.Text = nuggets.GetInfo();


        }

    }
}
