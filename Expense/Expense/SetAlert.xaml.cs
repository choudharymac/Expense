﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class SetAlert : ContentPage
    {
        public ListView ListView { get { return listView; } }

        ObservableCollection<AlertDrawerItems> masterPageItems = new ObservableCollection<AlertDrawerItems>();

        public SetAlert()
        {
            InitializeComponent();
            if (!GlobalAlert.Cat.Equals(""))
            {
                masterPageItems.Add(new AlertDrawerItems
                {
                    Alert = GlobalAlert.Cat,
                    Amount = GlobalAlert.Amount+" USD",
                    IconSource = "bell.png",
                });
                listView.ItemsSource = masterPageItems;
            }
            else
            {
                masterPageItems.Add(new AlertDrawerItems
                {
                    Alert = "Low Balance",
                    Amount = "30 USD",
                    IconSource = "bell.png",
                });
                listView.ItemsSource = masterPageItems;
            }
        }
        private void OnAddAlert(object sender, EventArgs args)
        {
            GlobalAlert.Cat = message.Text;
            GlobalAlert.Amount = Int32.Parse(alertamount.Text);
          masterPageItems.Add(new AlertDrawerItems
            {
                Alert = message.Text,
                Amount = alertamount .Text+ " USD",
                IconSource = "bell.png",
            });
            listView.ItemsSource = masterPageItems;
        }
    }
}
