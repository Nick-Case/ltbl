﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTBLApplication.Controls;
using Xamarin.Forms;

namespace LTBLApplication.Views
{
    public partial class MainMenu : ContentPage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            SetupMenu();
        }

        /// <summary>
        /// Sets up the menu view
        /// </summary>
        private void SetupMenu()
        {
            Menu.ItemsSource = new List<string>
            {
                "New Device",
                "Import View",
                "Export View",
                "About"
            };
            Menu.ItemSelected += Menu_ItemSelected;
        }

        /// <summary>
        /// Called when a menu item is selected by the user
        /// </summary>
        /// <param name="_sender">List View</param>
        /// <param name="_e"></param>
        private void Menu_ItemSelected(object _sender, SelectedItemChangedEventArgs _e)
        {
            ListView view = (ListView) _sender;
            var selected = (String)view.SelectedItem;
            DisplayAlert("Selected", selected, "OK");
            switch (selected)
            {
                case "New Device":
                {
                    //navigate to new device page
                    break;
                }
                case "Import View":
                {
                    //navigate to Import View page
                    break;
                }
                case "Export View":
                {
                    //navigate to export view
                    break;
                }
                case "About":
                {
                    //navigate to about page
                    break;
                }
            }
        }
    }
}
