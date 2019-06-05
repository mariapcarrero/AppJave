using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.Services.Restful;
using JaverianaCali.ViewModels;
using Xamarin.Forms;
using SkiaSharp.Views.Forms;

namespace JaverianaCali.Views
{
    public partial class LoginView : ContentPage
    {
        private LoginViewModel context;
        readonly HighlightForm _highlightForm;
        public LoginView()
        {
            InitializeComponent();
            context = new LoginViewModel();
            BindingContext = context;
            var settings = new HighlightSettings()
            {
                StrokeWidth = 6,
                StrokeStartColor = Color.FromHex("#FF4600"),
                StrokeEndColor = Color.FromHex("#CC00AF"),
                AnimationDuration = TimeSpan.FromMilliseconds(900),
                AnimationEasing = Easing.CubicInOut,
            };

            _highlightForm = new HighlightForm(settings);
        }

        private async Task Login()
        {
            UserModel user = await context.AttemptLogin();
            if (user == null) {
                await DisplayAlert("Autenticacion fallida", "Datos de inicio incorrectos", "OK");
            } else {
                CoursesView coursesView = new CoursesView(user);
                await Navigation.PushAsync(coursesView);
                await coursesView.Init();
            }
        }

        private async void ClickedLogin(object sender, EventArgs args) {
            await Login();
        }
    }
}
