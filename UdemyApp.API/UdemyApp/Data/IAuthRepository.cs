using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyApp.Models;

namespace UdemyApp.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string userName, string password);
        Task<bool> UserExist(string userName);
    }
}
