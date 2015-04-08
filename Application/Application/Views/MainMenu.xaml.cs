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
        public void SetupMenu()
        {
            Menu.ItemsSource = new List<string>
            {
                "New Button",
                "New Slider",
                "New Switch",
                "Import View",
                "Export View",
                "About"
            };
            Menu.ItemTapped += Menu_ItemSelected;
        }

        /// <summary>
        /// Called when a menu item is selected by the user
        /// </summary>
        /// <param name="_sender">List View</param>
        /// <param name="_e"></param>
        private async void Menu_ItemSelected(object _sender, ItemTappedEventArgs _e)
        {
            var view = (ListView) _sender;
            var selected = (String)view.SelectedItem;

            switch (selected)
            {
                case "New Button":
                {
                    //navigate to new device page
                    await Navigation.PushAsync(new AddButtonView(), true);
                    break;
                }
                case "New Slider":
                {
                    //navigate to new slider page
                    await Navigation.PushAsync(new AddSliderView(), true);
                    break;
                }
                case "New Switch":
                {
                    //navigate to new switch page
                    await Navigation.PushAsync(new AddSwitchView(), true);
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
