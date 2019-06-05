using System;
namespace JaverianaCali.Models
{
    public class GradeModel {

        private String name;
        private double calification;
        private double percentage;

        public GradeModel(String name, double calification, double percentage) {
            this.name = name;
            this.calification = calification;
            this.percentage = percentage;
        }

        public String Name {
            get { return name; }
            set { name = value; }
        }

        public double Calification {
            get { return calification; }
            set { calification = value; }
        }

        public double Percentage {
            get { return percentage; }
            set { percentage = value; }
        }
    }
}
