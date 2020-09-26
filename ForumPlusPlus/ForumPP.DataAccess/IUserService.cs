using ForumPP.DataAccess.DbModels;
using ForumPP.WebModels.AccontViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumPP.DataAccess
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        SignInResult Login(LoginViewModel loginModel);
        void Logout();
        User GetById(string userId);
        IEnumerable<User> GetAll();
        int SetProfileImage(User user, string fileName);
        Task IncementRating(string userId, Type type);
    }
}
