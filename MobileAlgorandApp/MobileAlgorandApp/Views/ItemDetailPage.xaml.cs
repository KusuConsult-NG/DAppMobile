using System.ComponentModel;
using Xamarin.Forms;
using MobileAlgorandApp.ViewModels;

namespace MobileAlgorandApp.Views
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