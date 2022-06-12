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
            hambuger = new Snack("Hamburger", 2, true, 50);
            frites = new Snack("Frites", 1, true, 35);
            nuggets = new Snack("Nuggets", 1.3, false, 35);

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

            if (numberSnack1 > 0 && numberSnack1 <= hambuger.GetNumberInStock())
            { lbSnack1Amount.Text = $"{numberSnack1}  {hambuger.Name}: ";
              hambuger.SellSome(numberSnack1); 
              lbSnack1Cal.Text = $"Euro {hambuger.CalculateSnack(numberSnack1)}"; 
              lbSnack1Info.Text = hambuger.GetInfo();
            } 
            else if (numberSnack1 > hambuger.GetNumberInStock())
            {
               lbSnackbarBuyer.Text = hambuger.notEnoughSnack();
            }


            if (numberSnack2 > 0 && numberSnack2 <= frites.GetNumberInStock())
            {
                lbSnack2Amount.Text = $"{numberSnack2}  {frites.Name}: ";
                frites.SellSome(numberSnack2);
                lbSnack2Cal.Text = $"Euro {frites.CalculateSnack(numberSnack2)}";
                lbSnack2Info.Text = frites.GetInfo();
            }
            else if (numberSnack2 > frites.GetNumberInStock())
            {
                lbSnackbarBuyer.Text = frites.notEnoughSnack();
            }


            if( numberSnack3 > 0 && numberSnack3 <= nuggets.GetNumberInStock())
            {
                lbSnack3Amount.Text = $"{numberSnack3}  {nuggets.Name}:";
                nuggets.SellSome(numberSnack3);
                lbSnack3Cal.Text = $"Euro {nuggets.CalculateSnack(numberSnack3)}";
                lbSnack3Info.Text = nuggets.GetInfo();
            }
            else if (numberSnack2 > nuggets.GetNumberInStock())
            {
                lbSnackbarBuyer.Text = nuggets.notEnoughSnack();
            }

            //Er kan sws een makkelijkere manier (met een methode ofzo). docent vragen om dit op te lossen   
            double TotalPrice = hambuger.CalculateSnack(numberSnack1) + frites.CalculateSnack(numberSnack2) + nuggets.CalculateSnack(numberSnack3);
            lbTotalPrice.Text = $"Euro {TotalPrice}";



            if (hambuger.GetNumberInStock() < 20)
            {
               lbSnackbarOwner.Text =  hambuger.AddSnackMessage();
            }
            else if(frites.GetNumberInStock() < 15)
            {
                lbSnackbarOwner.Text = frites.AddSnackMessage();
            } 
            else if (nuggets.GetNumberInStock() < 15)
            {
                lbSnack1Amount.Text = nuggets.AddSnackMessage();
            }
        }

        private void btnUpdateSnackInfo_Click(object sender, EventArgs e)
        {
                if (rbSnack1.Checked)
                {
                    hambuger.SetCostPrice(Convert.ToDouble(nSetPrice.Value));
                    hambuger.AddSnack(Convert.ToInt32(nAddsnack.Value));
                    lbSnack1Info.Text = hambuger.GetInfo();
                }
                else if (rbSnack2.Checked)
                {
                    frites.SetCostPrice(Convert.ToDouble(nSetPrice.Value));
                    frites.AddSnack(Convert.ToInt32(nAddsnack.Value));
                    lbSnack2Info.Text = frites.GetInfo();
                }
                else if (rbSnack3.Checked)
                {
                    nuggets.SetCostPrice(Convert.ToDouble(nSetPrice.Value));
                    nuggets.AddSnack(Convert.ToInt32(nAddsnack.Value));
                    lbSnack3Info.Text = nuggets.GetInfo();
                }
        }
    }
}
