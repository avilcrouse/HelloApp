using HelloApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HelloApp.Views
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