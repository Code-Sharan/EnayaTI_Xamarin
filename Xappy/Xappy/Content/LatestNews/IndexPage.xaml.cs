using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xappy.LatestNews
{
    public partial class IndexPage : ContentPage
    {
        public IndexPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
