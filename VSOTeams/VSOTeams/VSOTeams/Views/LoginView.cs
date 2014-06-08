﻿using System;
using VSOTeams.Helpers;
using Xamarin.Forms;

namespace VSOTeams.Views
{
    class LoginView : ContentPage
    {
        readonly LoginInfo _credentials = new LoginInfo();
        public LoginView()
        {
            Padding = new Thickness(20);
            Title = "Login";
            BindingContext = _credentials;

            Entry accountInput = new Entry { Placeholder = "VSO Account" };
            accountInput.SetBinding(Entry.TextProperty, "Account");

            Entry loginInput = new Entry { Placeholder = "User Name" };
            loginInput.SetBinding(Entry.TextProperty, "UserName");

            Entry passwordInput = new Entry { IsPassword = true, Placeholder = "Password" };
            passwordInput.SetBinding(Entry.TextProperty, "Password");

            Button loginButton = new Button
            {
                Text = "Login",
                BorderRadius = 5,
                TextColor = Colours.LightBlue,
                BackgroundColor = Colours.BackgroundGrey
            };
            loginButton.Clicked += LogMeIn;

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                          {
                              accountInput,
                              loginInput,
                              passwordInput,
                              loginButton
                          },
                Spacing = 10,
            };
        }
        async void LogMeIn(object sender, EventArgs eventArgs)
        {
            if (_credentials.CanLogin() == true)
            {
                //inlggen
            }

            await Navigation.PopAsync();

        }
    }
}