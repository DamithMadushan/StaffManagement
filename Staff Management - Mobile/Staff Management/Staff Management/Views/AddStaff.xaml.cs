using Newtonsoft.Json;
using SM.Domain.DTO;
using SM.Model.Models;
using Staff_Management.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Staff_Management.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddStaff : ContentPage
    {
        public AddStaff()
        {
            InitializeComponent();

        }


        /// <summary>
        /// On save button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Save_Button_Clicked(object sender, EventArgs e)
        {
            if (title.SelectedIndex <= -1 || string.IsNullOrEmpty(entityFirstName.Text) || string.IsNullOrEmpty(entityLastName.Text) || StaffType.SelectedIndex <= -1 || Status.SelectedIndex <= -1)
            {
           
            await DisplayAlert("Info", "Please fill required fields", "OK");

            }
            else
            {
                StaffDto staffDto = new StaffDto();

                staffDto.TitleId = title.SelectedIndex;
                staffDto.FirstName = entityFirstName.Text;
                staffDto.LastName = entityLastName.Text;
                staffDto.MiddleInitial = entityMiddleInitial.Text;
                staffDto.CellPhone = entityCellphone.Text;
                staffDto.OfficeExtention = entityOfficeExtention.Text;
                staffDto.Irdnumber = entityIRDNumber.Text;
                staffDto.Username = entityUserName.Text;
                staffDto.Password = entityPassword.Text == "" ? entityPassword.Text : ExtentionsMethods.Hash(entityPassword.Text!);
                staffDto.ManagerId = Manager.SelectedIndex;
                staffDto.StaffTypeId = StaffType.SelectedIndex;
                staffDto.StatusId = Status.SelectedIndex;


                await SaveData(staffDto);
            }


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await GetInitialData();
        }


        private async Task SaveData(StaffDto staffDto)
        {

            try
            {
                string uri = ApiUrl.apiUrl + "Staff/SaveStaffMember";

                //handele ssl certificate errors for dev environment 
                HttpClientHandler clientHandler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
                };
                HttpClient httpClient = new HttpClient(clientHandler);

                string serializedObject = JsonConvert.SerializeObject(staffDto);
                HttpContent contentPost = new StringContent(serializedObject, Encoding.UTF8, "application/json");

                HttpResponseMessage httpResponse = await httpClient.PostAsync(uri, contentPost);

                if (httpResponse.IsSuccessStatusCode)
                {

                    await DisplayAlert("Success", $"Successfully saved", "OK");

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to save data: {ex.Message}", "OK");
            }


        }


            private async Task GetInitialData()
            {

            try
            {
                string uri = ApiUrl.apiUrl + "Staff/GetInitialData";

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

                    InitialDto data = JsonConvert.DeserializeObject<InitialDto>(response);


                    //add title dropdown values
                    title.ItemsSource = data.titles;

                    //add managers dropdown values
                    Manager.ItemsSource = data.managers;


                    //add staffTypes dropdown values
                    StaffType.ItemsSource = data.staffTypes;


                    //add statuses dropdown values
                    Status.ItemsSource = data.statuses;

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to fetch dropdown values: {ex.Message}", "OK");
            }


        }

        private void StaffListClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StaffView());
        }
    }
}