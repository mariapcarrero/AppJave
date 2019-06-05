using System;
using System.Collections.Generic;
using JaverianaCali.Models;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class BooksView : ContentPage
    {
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
    }
}
