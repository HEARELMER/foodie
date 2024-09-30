using Prueba.Models;
using Prueba.ViewModels;
using Prueba.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();
            carga();
            BindingContext = _viewModel = new ItemsViewModel();
        }
        async void carga()
        {
            var comidas = await App.SQLiteBD.GetItemAsync();
            CollectionItem.ItemsSource = comidas;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}