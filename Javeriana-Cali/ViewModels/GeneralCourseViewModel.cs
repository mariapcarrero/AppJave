using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.Services;

namespace JaverianaCali.ViewModels
{
    public class GeneralCourseViewModel : GeneralCourseModel {

        private readonly CourseService courseService = new CourseService();
        private ObservableCollection<GeneralCourseModel> courses;

        public async Task Init(UserModel user) {
            this.courses = await courseService.findCoursesByStudent(user);
        }

        public ObservableCollection<GeneralCourseModel> Courses {
            get { return courses; }
        }

    }
}
