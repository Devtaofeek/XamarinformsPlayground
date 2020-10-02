using System;
using System.Collections.Generic;
using Xamarin_Forms_Playground.ViewModels;
using Xamarin_Forms_Playground.Views;
using Xamarin.Forms;

namespace Xamarin_Forms_Playground
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
