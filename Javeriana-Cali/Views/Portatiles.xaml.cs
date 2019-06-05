using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JaverianaCali.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Portatiles : ContentPage
    {
        private PortatilesViewModel context;
        private UserModel user;
        public Portatiles(UserModel user)
        {
            InitializeComponent();
            context = new PortatilesViewModel(user);
            BindingContext = context;
            this.user = user;
        }

        private async void ClickedLogOut(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoginView());
        }

        private async void ClickedProfile(object sender, EventArgs args)
        {
            await DisplayAlert(user.Name + " " + user.Lastname, "Codigo: " + user.Id.ToString(), "Ok");
        }

        private async void ClickedAsignaturas(object sender, EventArgs e)
        {
            CoursesView view = new CoursesView(user);
            await Navigation.PushAsync(view);
            await view.Init();
        }

        private async void ClickedLibros(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BooksView(user));
        }

        private async void ClickedAjustes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ajustes(user));
        }
    }
}