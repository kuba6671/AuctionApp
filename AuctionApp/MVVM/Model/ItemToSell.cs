using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace AuctionApp.MVVM.Model
{
    public class ItemToSell
    {
        private int id;
        private String size;
        private String state;
        private String category;
        private String name;
        private String username;
        private double price;
        private string itemURL;
        private ImageSource itemImage;
        private MySqlDataReader rdr;

        public ItemToSell(int id,ImageSource itemImage, string category, string size, string state, double price, string name)
        {
            this.id = id;
            this.username = User.getUsername();
            this.size = size;
            this.state = state;
            this.category = category;
            this.name = name;
            this.price = price;
            this.itemImage = itemImage;
            this.itemURL = itemImage.ToString();
        }
        public ItemToSell(int id,string size, string state,string category, string name, double price, string itemURL)
        {
            this.id = id;
            this.username = User.getUsername();
            this.size = size;
            this.state = state;
            this.category = category;
            this.name = name;
            this.price = price;
            this.itemURL = itemURL;
        }
        public ItemToSell(ImageSource itemImage, string category, string size, string state, double price, string name)
        {
            this.username = User.getUsername();
            this.size = size;
            this.state = state;
            this.category = category;
            this.name = name;
            this.price = price;
            this.itemImage = itemImage;
            this.itemURL = itemImage.ToString();
        }
        public ItemToSell(string size, string state, string category, string name, double price, string itemURL)
        {
            this.username = User.getUsername();
            this.size = size;
            this.state = state;
            this.category = category;
            this.name = name;
            this.price = price;
            this.itemURL = itemURL;
        }

        public ItemToSell(MySqlDataReader rdr)
        {
            this.rdr = rdr;
        }

        public int getId()
        {
            return id;
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

        public ImageSource getImage()
        {
            return itemImage;
        }

        public string getURL()
        {
            return itemURL;
        }

        public MySqlDataReader getRdr()
        {
            return rdr;
        }
    }
}
