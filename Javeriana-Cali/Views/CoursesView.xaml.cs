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
                Navigation.PushAsync(new DetailedCourseView(detailedCourse));
            }
        }

        private async void ClickedBooks(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new BooksView(user));
        }

    }
}
