using System;
using CafetoteAPP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CafetoteAPP.ViewModels;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CafetoteAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SplashScreenPage();
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
