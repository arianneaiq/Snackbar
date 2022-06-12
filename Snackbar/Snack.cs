using System;
using System.Collections.Generic;
using System.Text;

namespace Snackbar
{
    internal class Snack
    {
        private String name;
        private double costPrice;
        private bool isVegetarian;
        private int numberInStock;
        
        //Constructor
        public Snack (string aName, double aCostPrice, bool aIsVegetarian, int aNumberInStock )
        {
            name = aName;
            costPrice = aCostPrice; 
            isVegetarian = aIsVegetarian;
            numberInStock = aNumberInStock;
        }
      
       public string Name
        {
            get { return name; }
        }

        public void SetCostPrice(double CostPrice)
        {
            costPrice = CostPrice;
        }
        
        public double GetSellingPrice()
        {
            return costPrice * 1.6;
        }

        public String Vegetarian()
        {
            if (isVegetarian == true)
            {
                return "Vegetarian";
            }else
            {
                return "not Vegetarian";
            }
        }

        public int GetNumberInStock()
        {
            return numberInStock;
        }

        public void AddSnack (int snack)
        {
            numberInStock += snack;
        }
        
        public String GetInfo()
        {
            return $"{name} is euro {GetSellingPrice()} ({GetNumberInStock()} in stock). It is {Vegetarian()}.";
        }

        public void SellSome (int n)
        {
            numberInStock -= n ;
        }

        public double CalculateSnack (double m)
        {
           return m *= GetSellingPrice();
        }

        public string AddSnackMessage()
        {
            return $"Hey Snackbar owner, please add some more {name}. There is only {GetNumberInStock()} {name} in stock ";
        }

        public string notEnoughSnack ()
        {
            return $"Sorry, there's not enough {name} in stock. You can only buy {GetNumberInStock()} {name}.";
        }
        
    }
}
