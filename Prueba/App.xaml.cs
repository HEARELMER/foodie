using Prueba.Data;
using Prueba.Services;
using Prueba.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
namespace Prueba
{
    public partial class App : Application
    {
        static SQLhelp db;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }
        public static SQLhelp SQLiteBD
        {
            get
            {
                if (db == null)
                {
                    db = new SQLhelp(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "prueba.db3"));
                }
                return db;
            }
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
