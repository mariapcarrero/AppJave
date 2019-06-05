using System;
namespace JaverianaCali.Models
{
    public class ScheduleModel {

        private String initialDate;
        private String endDate;
        private String classroom;
        private String teacher;
        private String day;

        public ScheduleModel(String initialDate, String endDate, String classroom, String teacher, String day) {
            this.initialDate = initialDate;
            this.endDate = endDate;
            this.classroom = classroom;
            this.teacher = teacher;
            this.day = day;
        }

        public string InitialDate { get => initialDate; set => initialDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Classroom { get => classroom; set => classroom = value; }
        public string Teacher { get => teacher; set => teacher = value; }
        public string Day { get => day; set => day = value; }
    }


    static class Conversion {
        public static String ConvertDayToString(int day) {
            switch (day) {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miercoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sabado";
            }
            return "Domingo";
        }
    }


}
