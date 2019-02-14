using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Homework3_1
{
    public partial class animalPage : ContentPage
    {
        public animalPage()
        {
            InitializeComponent();

        }
        public animalPage(string type,string name)
        { 

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            //shows the correct image and message
            if (type == "Dog")
            {
                dogImage.IsVisible = true;
                petName.Text += name;
                petName.Text += " to say hello!";
            }
            else if (type == "Cat")
            {
                catImage.IsVisible = true;
                petName.Text += name;
                petName.Text += " to say hello!";
            }


        }

        //when the dogs is clicked
        async void dog_Clicked(object sender, System.EventArgs e)
        {
            await dogImage.RotateTo(10, 100);
            await dogImage.RotateTo(-10, 100);
            await dogImage.RotateTo(10, 100);
            await dogImage.RotateTo(-10, 100);
            await dogImage.RotateTo(10, 100);
            await dogImage.RotateTo(0, 100);
        }
        //when the cat is clicked
        async void cat_Clicked(object sender, System.EventArgs e)
        {
            await catImage.RotateTo(10, 100);
            await catImage.RotateTo(-10, 100);
            await catImage.RotateTo(10, 100);
            await catImage.RotateTo(-10, 100);
            await catImage.RotateTo(10, 100);
            await catImage.RotateTo(0, 100);

        }
        //pop back to main page
        async void newpet_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }

}
