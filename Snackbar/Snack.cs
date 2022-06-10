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

        public int GetNumberInStock()
        {
            return numberInStock;
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
        
    }
}
