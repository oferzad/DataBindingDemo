using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new DemoBindingINotification();
            MainPage = new DemoInternalDataBinding();
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
