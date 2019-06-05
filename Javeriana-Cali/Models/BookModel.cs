using System;
namespace JaverianaCali.Models
{
    public class BookModel : AbstractModel
    {
        private String name;
        private String status;
        private String expiringDate;

        public BookModel() { }

        public BookModel(String name, String status, String expiringDate) {
            this.Name = name;
            this.Status = status;
            this.ExpiringDate = expiringDate;
        }

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public string ExpiringDate { get => expiringDate; set => expiringDate = value; }

        public String GetDetailedInformation
        {
            get
            {
                return "Estado: " + status + "\n" + "Fecha de expiracion: " + expiringDate + "\n";
            }
        }
    }
}
