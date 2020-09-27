using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumPlusPlus.Models.ForumViewModels;
using ForumPlusPlus.Models.PostViewModels;
using ForumPP.DataAccess;
using ForumPP.DataAccess.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumPlusPlus.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        public ForumController(IForum forumService,
                                IPost postService,
                                UserManager<User> userManager,
                                IUserService userService)
        {
            _forumService = forumService;
            _postService = postService;
            _userManager = userManager;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumViewModel
                {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description,
                    PostsCount = forum.Posts.Count(),
                    UserName = forum.User.UserName,
                    UserRating = forum.User.Rating,
                    Created = forum.Created
                });
            
            

            var model = new ForumIndexModel
            {
                ForumViewModels = forums
            };

            return View(model);
        }

        public IActionResult Topic(int forumId, string searchQuery)
        {
            var forum = _forumService.GetById(forumId);
            var posts = _postService.GetSeacrhedPosts(forum, searchQuery);

            var forumViewModel = new ForumViewModel
            {
                Id=forum.Id,
                Description=forum.Description,
                Name=forum.Title,
                ImageUrl=forum.ImageUrl,
                UserName= forum.User.UserName,
                UserRating=forum.User.Rating,
                Created=forum.Created
            };

            var postViewModels = posts.Select(p => new PostViewModel
            {
                Id = p.Id,
                AuthorId = p.User.Id,
                AuthorRating = p.User.Rating,
                AuthorName = p.User.UserName,
                Title = p.Title,
                DatePosted = p.Created.ToString("dd/MM/yyyy"),
                RepliesCount = p.Replies.Count(),
            });

           

            var model = new ForumTopicModel
            {
                Posts = postViewModels,
                Forum = forumViewModel
            };

            return View(model);
        }

        public IActionResult CreateForum()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateForum(ForumViewModel forum)
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var model = new Forum
            {
                ImageUrl = forum.ImageUrl,
                Description = forum.Description,
                Created = DateTime.Now,
                Title = forum.Name,
                User = user,
            };

            _forumService.Create(model);
            _userService.IncementRating(user.Id, typeof(Forum));
            return RedirectToAction("Index", "Forum");
        }

        [HttpPost]
        public IActionResult Search(int forumId, string searchQuery)
        {
            return RedirectToAction("Topic", new { forumId, searchQuery });
        }
    }
}
