using Xamarin.Forms;
using Xappy.About.ViewModels;

namespace Xappy.About
{
    public partial class IndexPage : ContentPage
    {
        public IndexPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            VersionsList.SelectedItem = null;
            //await ((IndexViewModel)BindingContext).OnAppearing();
        }
    }
}