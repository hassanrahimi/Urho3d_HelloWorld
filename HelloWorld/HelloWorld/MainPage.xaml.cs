using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Urho;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

           await HelloWorldUrhoSharp.Show<MyHelloWord>(new Urho.ApplicationOptions(assetsFolder: null) { Orientation = ApplicationOptions.OrientationType.LandscapeAndPortrait });
        }
    }
}
