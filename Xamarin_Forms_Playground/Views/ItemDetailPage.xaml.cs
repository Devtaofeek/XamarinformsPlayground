using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Forms_Playground.ViewModels;

namespace Xamarin_Forms_Playground.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}