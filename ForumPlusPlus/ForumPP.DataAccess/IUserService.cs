using ForumPP.DataAccess.DbModels;
using ForumPP.WebModels.AccontViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumPP.DataAccess
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void Login(LoginViewModel loginModel);
        void Logout();
        User GetById(string userId);
        IEnumerable<User> GetAll();
        Task SetProfileImage(string userId, Uri uri);
        Task IncementRating(string userId, Type type);
    }
}
