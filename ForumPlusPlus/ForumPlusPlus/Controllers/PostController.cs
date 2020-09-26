using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumPlusPlus.Models.PostViewModels;
using ForumPlusPlus.Models.ReplyViewModels;
using ForumPP.DataAccess;
using ForumPP.DataAccess.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumPlusPlus.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        public PostController(IPost postService, 
                                IForum forumService, 
                                UserManager<User> userManager, 
                                IUserService userService)
        {
            _postService = postService;
            _forumService = forumService;
            _userManager = userManager;
            _userService = userService; 
        }

        public IActionResult Index(int postId)
        {
            var post = _postService.GetById(postId);
            
            var replies = post.Replies.Select(r => new PostReplyViewModel
            {
                Id = r.Id,
                AuthorName = r.User.UserName,
                AuthorId = r.User.Id,
                AuthorImageUrl = r.User.ProfileImageUrl,
                AuthorRating = r.User.Rating,
                Created = r.Created,
                ReplyContent = r.Content,
                IsAuthorAdmin = _userManager.GetRolesAsync(r.User).Result.Contains("Admin")

            });

            var model = new PostIndexModel
            {
                Id=post.Id,
                Title=post.Title,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorImageUrl = post.User.ProfileImageUrl,
                AuthorRating = post.User.Rating,
                Created =post.Created,
                PostContent=post.Content,
                Replies=replies,
                ForumTopic=post.Forum.Title,
                ForumId=post.Forum.Id,
                IsAuthorAdmin = _userManager.GetRolesAsync(post.User).Result.Contains("Admin")

            };
             
            return View(model);
        }

        public IActionResult Create(int forumId)
        {
            var forum = _forumService.GetById(forumId);

            var NewPostViewModel = new NewPostViewModel
            {
                ForumName= forum.Title,
                ForumId=forum.Id,
                ForumImageUrl=forum.ImageUrl,
                AuthorName=User.Identity.Name
            };

            return View(NewPostViewModel);
        }
        [HttpPost]
        public IActionResult Create(NewPostViewModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;

            var forum = _forumService.GetById(model.ForumId);

            var post = new Post
            {
                User= user,
                Title= model.Title,
                Content=model.Content,
                Created= DateTime.Now,
                Forum = forum
            };


            _postService.Add(post).Wait();
            _userService.IncementRating(user.Id, typeof(Post));
            return RedirectToAction("Index", "Post" , new { postId = post.Id});
        }
    }
}
