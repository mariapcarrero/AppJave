using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public interface CourseServiceInterface {

        Task<ObservableCollection<GeneralCourseModel>> findCoursesByStudent(UserModel user);
        GeneralCourseModel FindCourseDetail(UserModel user, GeneralCourseModel course);

    }
}
