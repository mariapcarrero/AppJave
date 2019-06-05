using System;
namespace JaverianaCali.Models
{
    public class LoginModel : AbstractModel {

        private String username;
        private String password;

        public LoginModel() {
        }

        public String Username {
            get { return username; }
            set { username = value; OnPropertyChanged(); }
        }

        public String Password {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }

    }
}
