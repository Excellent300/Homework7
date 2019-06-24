using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework7._1.ViewModels
{
    public class ShopItemModel
    {
        //Data Members
        string mName;
        string mDescription;
        double mPrice;
        int mQuantityAvailable;

        //Parametized constructor 
        public ShopItemModel(string Name, string Description, double Price, int QuantityAvailable)
        {
            mName = Name;
            mDescription = Description;
            mPrice = Price;
            mQuantityAvailable = QuantityAvailable;

        }

        //Empty Constructor
        public ShopItemModel()
        {
            mName = "";
            mDescription = "";
            mPrice = 0.00;
            mQuantityAvailable = 0;


        }




        public string Name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }

        public string Description
        {
            get
            {
                return mDescription;
            }

            set
            {
                mDescription = value;
            }
        }

        public double Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }

        public int QuantityAvailable
        {
            get
            {
                return mQuantityAvailable;
            }

            set
            {
                mQuantityAvailable = value;
            }
        }

        public string getName
        {
            get { return Name; }
            set
            {
                Name = value;

            }

        //    private List<ShopItemModel> orderByName(List<ShopItemModel> Item)
        //{
        //    return Items.OrderBy(zz => zz.getName).ToList(); ;
        //}
    }
        

        //public void orderRow()
        //{
        //    return OrderBy(zz => zz.getName).ToList();
        //}


























    }
}