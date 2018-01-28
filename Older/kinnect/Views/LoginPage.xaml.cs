﻿using System;
using System.Collections.Generic;
using kinnect.Models;
using Xamarin.Forms;

namespace kinnect.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lb1_Username.TextColor = Constants.MainTextColor;
            Lb1_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LogInIcon.HeightRequest = Constants.LoginIconHeight; 
             

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s,e);
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if(user.CheckInformation())
            {
                DisplayAlert("Login","Login Success","Nice");

            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, empty username or password.","Check Again");
            }
        }
    }
}
