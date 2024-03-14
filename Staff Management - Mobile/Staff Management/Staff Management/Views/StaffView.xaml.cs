using Newtonsoft.Json;
using SM.Domain.DTO;
using SM.Model.Models;
using Staff_Management.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Staff_Management.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffView : ContentPage
    {
        public StaffView()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await GetGridData();
        }



        private async Task GetGridData()
        {

            try
            {
                string uri = ApiUrl.apiUrl + "Staff/GetStaff";

                //handele ssl certificate errors for dev environment 
                HttpClientHandler clientHandler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
                };
                HttpClient httpClient = new HttpClient(clientHandler);


                HttpResponseMessage httpResponse = await httpClient.GetAsync(uri);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var response = httpResponse.Content.ReadAsStringAsync().Result;

                    List<StaffDto> data = JsonConvert.DeserializeObject<List<StaffDto>>(response);


                    listViewStaff.ItemsSource = data;



                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to fetch grid values: {ex.Message}", "OK");
            }


        }

    }
}