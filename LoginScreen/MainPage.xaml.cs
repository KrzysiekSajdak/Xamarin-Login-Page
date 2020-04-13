using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginScreen
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Entry userNameEntry;
        Entry passwordEntry;
        Button loginButton;
        StackLayout stackLayout;

        public MainPage()
        {
            userNameEntry = new Entry
            {
                Placeholder = "login"
            };

            passwordEntry = new Entry
            {
                Placeholder = "password",
                IsPassword = true
            };

            loginButton = new Button
            {
                Text = "log in"
            };

            loginButton.Clicked += LoginButton_Clicked;
            this.Padding = new Thickness(20);
            stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Children =
                {
                    userNameEntry,
                    passwordEntry,
                    loginButton
                }
            };

            this.Content = stackLayout;
        }
        void LoginButton_Clicked(object sender, EventArgs args)
        {
            Debug.WriteLine(string.Format("Login: {0} - Password: {1}",
                    userNameEntry.Text, passwordEntry.Text));
        }
    }
}

