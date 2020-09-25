using ForumPlusPlus.DataAccess;
using ForumPP.DataAccess;
using ForumPP.DataAccess.DbModels;
using ForumPP.WebModels.AccontViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumPP.Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;

        public UserService(SignInManager<User> signInManager, UserManager<User> userManager, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(string userId)
        {
            throw new NotImplementedException();
        }

        public Task IncementRating(string userId, Type type)
        {
            throw new NotImplementedException();
        }

        public void Login(LoginViewModel loginModel)
        {
           var result = _signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, false, false).Result;
            
            if (result.IsNotAllowed)
            {
                throw new Exception("Username or Password is not correct!");
            }
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel registerModel)
        {
            var user = new User { UserName = registerModel.Email, MemberSince = DateTime.Now };
            var result = _userManager.CreateAsync(user, registerModel.Password).Result;
            if (result.Succeeded)
            {
                Login(new LoginViewModel()
                {
                    Username=registerModel.Email,
                    Password=registerModel.Password
                });
            }
        }

        public async Task SetProfileImage(string userId, Uri uri)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            user.ProfileImageUrl = uri.AbsoluteUri;
            _context.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
