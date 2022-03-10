using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AuctionApp.MVVM.Model
{
    class ItemToSell
    {
        private String size, state, category, description;
        private double price;
        private Image itemImage;

        public ItemToSell(Image itemImage, string category,string size, string state, double price,string description)
        {
            this.size = size;
            this.state = state;
            this.category = category;
            this.description = description;
            this.price = price;
            this.itemImage = itemImage;
        }

        public String getSize()
        {
            return size;
        }
        public String getState()
        {
            return state;
        }
        public String getCategory()
        {
            return category;
        }
        public String getDescription()
        {
            return description;
        }

        public double getPrice()
        {
            return price;
        }
        
        public Image getImage()
        {
            return itemImage;
        } 
    }
}
