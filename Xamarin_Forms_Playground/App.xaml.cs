using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Forms_Playground.Services;
using Xamarin_Forms_Playground.Views;

namespace Xamarin_Forms_Playground
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
