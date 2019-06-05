using System;
using System.Collections.Generic;

namespace JaverianaCali.Models
{
    public class GeneralCourseModel : AbstractModel {

        private int id;
        private String name;
        private List<ScheduleModel> schedule = new List<ScheduleModel>();
        private List<GradeModel> grades = new List<GradeModel>();

        public GeneralCourseModel() {
        }

        public GeneralCourseModel(int id, String name) {
            this.id = id;
            this.name = name;
        }

        public int Id {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        public String Name {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public List<ScheduleModel> Schedule { get => schedule; set => schedule = value; }
        public List<GradeModel> Grades { get => grades; set => grades = value; }

        public void AddSchedule(ScheduleModel model)
        {
            schedule.Add(model);
        }

        public void AddGrade(GradeModel grade)
        {
            Grades.Add(grade);
        }

        public String GetDetailedInformation
        {
            get
            {
                String ans = "";
                for (int i = 0; i < schedule.Count; ++i)
                {
                    ans += schedule[i].Teacher + ", " + schedule[i].Classroom + ", " + schedule[i].Day + "\n";
                }
                return ans;
            }
        }

        public String GetGradesInformation
        {
            get
            {
                String ans = "";
                for (int i = 0; i < Grades.Count; ++i)
                {
                    ans += Grades[i].Name + "\nNota: " + Grades[i].Calification + "\nPorcentaje: " + Grades[i].Percentage + "%\n";
                }
                return ans;
            }
        }

    }
}
