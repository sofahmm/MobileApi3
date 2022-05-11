using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApi3.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApi3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CityWeatherPage : ContentPage
    {
        public Rootobject  Weather { get; set; }
        public CityWeatherPage()
        {
            InitializeComponent();
            Weather = new Rootobject();
            this.BindingContext = Weather;
        }
        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var city = searchBar.Text;
            Weather = await App.RequestManager.GetWeather(city);

            this.BindingContext = Weather;
        }
    }
}