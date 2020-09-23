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
        //private readonly UserManager _userManager;
        public ForumController(IForum forumService, IPost postService)
        {
            _forumService = forumService;
            _postService = postService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumViewModel
                {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description,
                    PostsCount= forum.Posts.Count()
                    
                });
            
            

            var model = new ForumIndexModel
            {
                ForumViewModels = forums
            };

            return View(model);
        }

        public IActionResult Topic(int forumId)
        {
            var forum = _forumService.GetById(forumId);
            var posts = _postService.GetForumPosts(forumId);

            var postViewModels = posts.Select(p => new PostViewModel
            {
                Id = p.Id,
                AuthorId = p.UserId,
                AuthorRating = p.User.Rating,
                AuthorName = p.User.UserName,
                Title = p.Title,
                DatePosted=p.Created.ToString("dd/MM/yyyy"),
                RepliesCount = p.Replies.Count(),
                Forum = ForumViewModelMapper(forum)
                
            });

            var model = new ForumTopicModel
            {
                Posts = postViewModels,
                Forum = ForumViewModelMapper(forum)
            };

            return View(model);
        }

        private ForumViewModel ForumViewModelMapper(Forum forum)
        {
            return new ForumViewModel
            {
                Id = forum.Id,
                Description = forum.Description,
                Name = forum.Title,
                ImageUrl=forum.ImageUrl
            };
        }
    }
}
