﻿using System;
using System.Collections.Generic;
using JaverianaCali.Models;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class DetailedCourseView : ContentPage
    {

        private DetailedCourseViewModel context;
        private UserModel user;
        public DetailedCourseView(GeneralCourseModel model, UserModel user)
        {
            InitializeComponent();
            context = new DetailedCourseViewModel(model);
            BindingContext = context;
        }
        private async void ClickedLibros(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new BooksView(user));
        }
        private async void ClickedLogOut(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoginView());
        }

        private async void ClickedPortatiles(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Portatiles(user));
        }


        private async void ClickedAjustes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ajustes(user));
        }

    }
}