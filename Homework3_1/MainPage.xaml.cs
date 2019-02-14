using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework3_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
            NavigationPage.SetHasNavigationBar(this, false);

        }
        //clicks on dog button
       async void Dog_Clicked(object sender, System.EventArgs e)
        {
            string animal = "Dog";
            await Navigation.PushAsync(new namePage(animal),true);
        }
        //clicks on cat button
        async void Cat_Clicked(object sender, System.EventArgs e)
        {
            string animal = "Cat";
            await Navigation.PushAsync(new namePage(animal),true);
        }
    }
}
