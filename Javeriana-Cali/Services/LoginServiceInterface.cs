using System;
using System.Threading.Tasks;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public interface LoginServiceInterface
    {
        Task<UserModel> validateCredentials(LoginModel loginModel);
    }
}
