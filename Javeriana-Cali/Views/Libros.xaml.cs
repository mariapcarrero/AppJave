using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JaverianaCali.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Libros : ContentPage
    {
        public Libros()
        {
            InitializeComponent();
        }

        private async void ClickedLogOut(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoginView());
        }

        private async void ClickedAsignaturas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoursesView());
        }
        private async void ClickedPortatiles(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Portatiles());
        }

        private async void ClickedAjustes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ajustes());
        }
    }
}