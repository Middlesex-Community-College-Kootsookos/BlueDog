﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BlueDog.Models;
using BlueDog.Views;
using BlueDog.ViewModels;

namespace BlueDog.Views
{
    public partial class ItemsPage : ContentPage
    {
        RobotInfosViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new RobotInfosViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
