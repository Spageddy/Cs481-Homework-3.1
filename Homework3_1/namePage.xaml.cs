using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Homework3_1
{
    public partial class namePage : ContentPage
    {
        string animalType;
        
        public namePage()
        {
            InitializeComponent();
            
        }
        //for entry box placeholder
        public namePage(string animal)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            animalType = animal;
            animalName.Placeholder += " ";
            animalName.Placeholder += animal;

        }

        //enter button is clicked
        async void Enter_Clicked(object sender, System.EventArgs e)
        {
           
            //sends the type of animal and animal name from entry
            await Navigation.PushAsync(new animalPage(animalType, animalName.Text),true);
        }
    }
}
