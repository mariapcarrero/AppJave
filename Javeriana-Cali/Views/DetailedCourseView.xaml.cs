using System;
using System.Collections.Generic;
using JaverianaCali.Models;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class DetailedCourseView : ContentPage
    {

        private DetailedCourseViewModel context;

        public DetailedCourseView(GeneralCourseModel model)
        {
            InitializeComponent();
            context = new DetailedCourseViewModel(model);
            BindingContext = context;
        }
    }
}
