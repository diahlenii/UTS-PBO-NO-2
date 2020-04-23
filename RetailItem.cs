using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailItem
{
    class RetailItem
    {
        
        private String description;		
        private int unitsOnHand; 			
        private double price;				

       

        public RetailItem()
        {
            description = " ";
            unitsOnHand = 0;
            price = 0.00;
        }

       
        public RetailItem(String description, int unitsOnHand, double price)
        {
            setDescription(description);
            setUnitsOnHand(unitsOnHand);
            setPrice(price);
        }

        public void setDescription(String itemDescription)
        {
            description = itemDescription;
        }
        public void setUnitsOnHand(int units)
        {
            unitsOnHand = units;
        }
        public void setPrice(double retailPrice)
        {
            price = retailPrice;
        }

        
        public String getDescription()
        {
            return description;
        }
        public int getUnitsOnHand()
        {
            return unitsOnHand;
        }
        public double getPrice()
        {
            return price;
        }
    }
}
