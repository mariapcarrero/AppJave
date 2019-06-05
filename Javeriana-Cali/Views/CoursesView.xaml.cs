using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.Services;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class CoursesView : ContentPage
    {

        private UserModel user;
        private GeneralCourseViewModel context;
        private CourseService courseService = new CourseService();

        public CoursesView(UserModel user)
        {
            InitializeComponent();
            this.user = user;
            context = new GeneralCourseViewModel();
            BindingContext = context;
            ListViewCourses.ItemSelected += ListViewCourses_ItemSelected;
        }

        public void UpdateView() {
            InitializeComponent();
            ListViewCourses.ItemSelected += ListViewCourses_ItemSelected;
        }

        public async Task Init() {
            await context.Init(user);
            UpdateView();
        }

        private void ListViewCourses_ItemSelected(object sender, SelectedItemChangedEventArgs eventArgument)
        {
            if (eventArgument.SelectedItem != null) {
                GeneralCourseModel model = (GeneralCourseModel)eventArgument.SelectedItem;
                GeneralCourseModel detailedCourse = courseService.FindCourseDetail(user, model);

                Navigation.PushAsync(new DetailedCourseView(detailedCourse,user));
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
