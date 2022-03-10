﻿using AuctionApp.Core;
using AuctionApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AuctionApp.MVVM.ViewModel
{
    class SellViewModel : ObservableObject
    {
        public RelayCommand addCommand { get; set; }

        public SellViewModel()
        {
            addCommand = new RelayCommand(o =>
            {
                string categoryString = category.ToString();
                string finalCategoryString = "";
                char[] categoryCharArray = categoryString.ToCharArray();
                bool isAdded = false;
                for(int i = 0; i < categoryCharArray.Length-2; i++)
                {
                    if(categoryString[i] == ':')
                        isAdded = true;
                    if(isAdded)
                        finalCategoryString += categoryString[i + 2];
                }
                Trace.WriteLine("finalCategoryString = " + finalCategoryString);
            });
        }

        private string size, state, description, price, category;
        public string getCategory
        {
            get { return this.category; }
            set
            {
                if (!string.Equals(this.category, value))
                {
                    this.category = value;
                    OnPropertyChanged("getCategory");
                }
            }
        }
        public string SizeText
        {
            get { return this.size; }
            set
            {
                if (!string.Equals(this.size, value))
                {
                    this.size = value;
                    OnPropertyChanged();
                }
            }
        }
        public string StateText
        {
            get { return this.state; }
            set
            {
                if (!string.Equals(this.state, value))
                {
                    this.state = value;
                    OnPropertyChanged();
                }
            }
        }
        public string DescriptionText
        {
            get { return this.description; }
            set
            {
                if (!string.Equals(this.description, value))
                {
                    this.description = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PriceText
        {
            get { return this.price; }
            set
            {
                if (!string.Equals(this.price, value))
                {
                    this.price = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}