using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JaverianaCali.ViewModels;
using JaverianaCali.Models;

namespace JaverianaCali.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ajustes : ContentPage
    {
        private AjustesViewModel context;
        private UserModel user;
        public Ajustes(UserModel user)
        {
            InitializeComponent();
            context = new AjustesViewModel(user);
            BindingContext = context;
            this.user = user;
        }

        private async void ClickedLogOut(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoginView());
        }

        private async void ClickedAsignaturas(object sender, EventArgs e)
        {
            CoursesView view = new CoursesView(user);
            await Navigation.PushAsync(view);
            await view.Init();
        }

        private async void ClickedPortatiles(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Portatiles(user));
        }

        private async void ClickedLibros(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BooksView(user));
        }

    }
}