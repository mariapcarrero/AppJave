using System;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.Services;
using JaverianaCali.Views;
using Xamarin.Forms;

namespace JaverianaCali.ViewModels
{
    public class LoginViewModel : LoginModel {
        private LoginService loginService = new LoginService();

        public LoginViewModel() {
            // This is used only to test if the extended class atributes are being displayed correctly
            this.Username = "mariapcarrero";
            this.Password = "Theolo123";
        }

        public async Task<UserModel> AttemptLogin() {
            return await loginService.validateCredentials(this);
        }
    }
}
