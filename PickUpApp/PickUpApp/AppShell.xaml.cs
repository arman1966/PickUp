﻿using PickUpApp.ViewModels;
using PickUpApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PickUpApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
