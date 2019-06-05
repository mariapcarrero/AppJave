using System;
using JaverianaCali.Models;

namespace JaverianaCali.ViewModels
{
    public class DetailedCourseViewModel : GeneralCourseModel {

        public DetailedCourseViewModel(GeneralCourseModel course)
        {
            this.Id = course.Id;
            this.Name = course.Name;
            this.Schedule = course.Schedule;
            this.Grades = course.Grades;
        }
    }
}
