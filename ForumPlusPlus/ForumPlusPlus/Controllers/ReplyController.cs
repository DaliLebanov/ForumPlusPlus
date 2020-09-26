using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumPlusPlus.Models.ReplyViewModels;
using ForumPP.DataAccess;
using ForumPP.DataAccess.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumPlusPlus.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IPost _postService;
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userServce;

        public ReplyController(IPost postService, 
                                UserManager<User> userManager,
                                IUserService userServce)
        {
            _postService = postService;
            _userManager = userManager;
            _userServce = userServce;
        }

        public IActionResult Create(int postId)
        {
            var post = _postService.GetById(postId);
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var model = new PostReplyViewModel
            {
                PostContent = post.Content,
                PostTitle = post.Title,
                PostId = post.Id,

                AuthorId = user.Id,
                AuthorName = user.UserName,
                AuthorImageUrl = user.ProfileImageUrl,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("admin"),

                Created = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddReply(PostReplyViewModel model)
        {
            var user = _userManager.FindByIdAsync(model.AuthorId).Result;
            var post = _postService.GetById(model.PostId);

            var reply = new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                Created = DateTime.Now,
                User = user,
            };

            _postService.AddReply(reply);
            _userServce.IncementRating(user.Id, typeof(PostReply));
            return RedirectToAction("Index", "Post", new { postId = model.PostId });
            
        }
    }
}
