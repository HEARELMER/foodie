using Prueba.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Prueba.Views
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