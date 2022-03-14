﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AuctionApp.MVVM.Model
{
    class ItemToSell
    {
        private String size;
        private String state;
        private String category;
        private String name;
        private String username;
        private double price;
        private Image itemImage;

        public ItemToSell(string username, Image itemImage, string category, string size, string state, double price, string name)
        {
            this.username = username;
            this.size = size;
            this.state = state;
            this.category = category;
            this.name = name;
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
        public String getName()
        {
            return name;
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
