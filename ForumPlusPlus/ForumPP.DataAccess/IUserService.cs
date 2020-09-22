using ForumPP.WebModels.AccontViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace ForumPP.DataAccess
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void Login(LoginViewModel loginModel);
        void Logout();
    }
}
