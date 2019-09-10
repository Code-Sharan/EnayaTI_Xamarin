using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xappy.Model;
using Xamarin.Essentials;

namespace Xappy.Content.Settings
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class StyleGuidePage : ContentPage
    {
        public StyleGuidePage()
        {
            InitializeComponent();
            //var mainDisplay = DeviceDisplay.MainDisplayInfo;
            //var width = mainDisplay.Width;
            //var height = mainDisplay.Height;
            //Plans.BindingContext = Application.Current.MainPage.Width;
            MainStackLayout.Margin = new Thickness(0, 10, 0, 0);
            CarouselStackLayout.HeightRequest = 100;
            //carousalImage.Source = ImageSource.FromFile("xamarin.png");
            carousalImage.Source = ImageSource.FromResource("Xappy.Images.xamarin.png");
            carousalImage.Aspect = Aspect.AspectFit;

            //Calling the API
            var client = new RestClient("http://5d67c9b06847d40014f664e8.mockapi.io");
            var get_Request = new RestRequest("/plans/", Method.GET);
            get_Request.RequestFormat = DataFormat.Json;
            var queryResult = client.Execute(get_Request);
            string response = queryResult.Content; //Getting the response from the API
            List<Plan> plan = JsonConvert.DeserializeObject<List<Plan>>(response);

            //HttpResponseMessage result = new HttpResponseMessage();
            //f1.Text = "Plan Name : " + plan[0].planName;
            //f2.Text = "Plan Description : " + plan[0].planDescription;
            //f3.Text = "Covers : " + plan[0].featureList[0].featureName;
            //f4.Text = "Covers : " + plan[0].featureList[1].featureName;
            //f5.Text = "Covers : " + plan[0].featureList[2].featureName;
            Plans.ItemsSource = plan;
        }


        protected override void OnAppearing()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 45, 0, 0);
            }
        }
    }
}