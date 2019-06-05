using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.Models.Restful;
using JaverianaCali.Services.Restful;

namespace JaverianaCali.Services
{
    public class CourseService : CourseServiceInterface {

        public CourseService() {
        }

        public GeneralCourseModel FindCourseDetail(UserModel user, GeneralCourseModel course)
        {
            course.AddGrade(new GradeModel("Examen 1", 5.0, 30.0));
            course.AddGrade(new GradeModel("Examen 2", 5.0, 30.0));
            course.AddGrade(new GradeModel("Examen 3", 5.0, 30.0));
            course.AddGrade(new GradeModel("Tareas", 5.0, 10.0));

            return course;
        }

        public async Task<ObservableCollection<GeneralCourseModel>> findCoursesByStudent(UserModel user) {
            ObservableCollection<GeneralCourseModel> courses = new ObservableCollection<GeneralCourseModel>();
            HttpRequest<List<RestfulGeneralCourseModel>> request = new HttpRequestBuilder<List<RestfulGeneralCourseModel>>().AddHeaderParameters(new String[] { "x-t6519fdd1s5q" }, new String[] { user.Token }).Build();
            List<RestfulGeneralCourseModel> restCourses = await request.Query("http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2/asignaturas");
            RestfulGeneralCourseModel rCourse = null;
            RestfulScheduleModel rCourseSchedule = null;
            for (int i = 0; i < restCourses.Count; i ++)
            {
                rCourse = restCourses[i];
                GeneralCourseModel model = new GeneralCourseModel(int.Parse(rCourse.Id), rCourse.Name);
                for (int j = 0; j < rCourse.Schedule.Count; j ++) {
                    rCourseSchedule = rCourse.Schedule[j];
                    model.AddSchedule(new ScheduleModel(rCourseSchedule.InitialDate, rCourseSchedule.EndDate, rCourseSchedule.Classroom, rCourseSchedule.Teacher, Conversion.ConvertDayToString(int.Parse(rCourseSchedule.Day))));
                }
                courses.Add(model);
            }
            return courses;
        }

    }
}
