using System;
using System.Collections.Generic;
using JaverianaCali.Models;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class BooksView : ContentPage
    {
        private UserModel user;
        public BooksView(UserModel user)
        {
            InitializeComponent();
            BindingContext = new BookViewModel(user);
            ListViewBooks.ItemSelected += ListViewBooks_ItemSelected;
        }

        private void ListViewBooks_ItemSelected(object sender, SelectedItemChangedEventArgs eventArgument)
        {
            if (eventArgument.SelectedItem != null)
            {

            }
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
