using GEMBA.Domain;
using Newtonsoft.Json;
using SM.Domain.DTO;
using Staff_Management.Common;
using Staff_Management.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Staff_Management
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AddStaff());
        }

        //Custom event that is raised when the application is starting
        private event EventHandler Starting = delegate { };

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
