using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.Models.Restful;
using JaverianaCali.Services.Restful;
using Newtonsoft.Json.Linq;

namespace JaverianaCali.Services
{
    public class LoginService : LoginServiceInterface {
    
        public LoginService() {
        }

        public async Task<UserModel> validateCredentials(LoginModel loginModel) {
            HttpRequest<RestfulAuthenticationModel> request = new HttpRequestBuilder<RestfulAuthenticationModel>().AddUrlParameters(new String[] { "usu", "pass" }, 
                                                                                                        new String[] { loginModel.Username, loginModel.Password }).Build();
            RestfulAuthenticationModel data = await request.Query("http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2/Autenticacion/");
            if (data.IsValido) {
                return new UserModel(int.Parse(data.Emplid), loginModel.Username, data.Nombre, data.Apellido, data.Token);
            }
            return null;
        }
    }
}
