using System;
namespace JaverianaCali.Models
{
    public class UserModel : AbstractModel {

        private int id;
        private String username;
        private String name;
        private String lastname;
        private String token;

        public UserModel(int id, String username, String name, String lastname, String token) {
            this.id = id;
            this.username = username;
            this.name = name;
            this.lastname = lastname;
            this.Token = token;
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public String Username {
            get { return username;  }
            set { username = value; }
        }

        public String Name {
            get { return name; }
            set { name = value;  }
        }

        public String Lastname {
            get { return lastname;  }
            set { lastname = value;  }
        }

        public string Token { get => token; set => token = value; }
    }
}
