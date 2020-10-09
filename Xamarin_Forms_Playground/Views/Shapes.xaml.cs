using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Forms_Playground.Models;

namespace Xamarin_Forms_Playground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shapes : ContentPage
    {

        public ObservableCollection<CarouselItem> CarouselItems { get; set; }
        public Shapes()
        {
            InitializeComponent();

            CarouselItems = new ObservableCollection<CarouselItem>
            {
               new CarouselItem
               {
                   Image = "Group3069.png", Text="Your delivery guys, never caught unfresh"
                   
               },
                 new CarouselItem
               {
                   Image = "Group3070.png", Text="Your delivery guys, never caught unfresh"
               },
                   new CarouselItem
               {
                   Image = "Group3071.png", Text="Sell your items with us and get it delivered to your customers."
               }
            };

            Carousel.ItemsSource = CarouselItems;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await image.RotateTo(360, 2000);
            image.Rotation = 0;
        }

       
        void OnCancelAnimationButtonClicked(object sender, EventArgs e)
        {
            ViewExtensions.CancelAnimations(image);
        }
    }
}