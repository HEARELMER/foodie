using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Collections.Specialized.BitVector32;

namespace Prueba.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
         
        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new PaginaSesion());
        }

        private void btnSignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}