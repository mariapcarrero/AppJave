using JaverianaCali.Helpers;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class CoursesListView : ContentPage
    {
        public CoursesListView()
        {
            if (Device.RuntimePlatform != Device.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            NavigationPage.SetBackButtonTitle(this, string.Empty);

            InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(false);
        }
    }
}