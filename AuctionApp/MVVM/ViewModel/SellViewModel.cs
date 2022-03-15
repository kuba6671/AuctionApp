﻿using AuctionApp.Core;
using AuctionApp.MVVM.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace AuctionApp.MVVM.ViewModel
{
    class SellViewModel : ObservableObject
    {
        public RelayCommand addCommand { get; set; }
        public RelayCommand addPhotoCommand { get; set; }


        public SellViewModel()
        {
            addCommand = new RelayCommand(o =>
            {
                string categoryString = category.ToString();
                double price = Convert.ToDouble(PriceText);
                ItemToSell newItem = new ItemToSell(ItemPhoto, categoryString, SizeText, StateText, price, NameText);
            });

            addPhotoCommand = new RelayCommand(o =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    Uri fileUri = new Uri(openFileDialog.FileName);
                    ItemPhoto = new BitmapImage(fileUri);
                }
            });
        }

        private ImageSource _ItemPhoto;

        public ImageSource ItemPhoto
        {
            get { return _ItemPhoto; }
            set
            {
                _ItemPhoto = value;
                OnPropertyChanged();
            }
        }

        private string size, state, name, price, category="Mężczyzna";
        public string getCategory
        {
            get { return this.category; }
            set
            {
                if (!string.Equals(this.category, value))
                {
                    this.category = value;
                    OnPropertyChanged();
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
        public string NameText
        {
            get { return this.name; }
            set
            {
                if (!string.Equals(this.name, value))
                {
                    this.name = value;
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
