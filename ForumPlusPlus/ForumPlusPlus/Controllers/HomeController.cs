using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ForumPlusPlus.Models;
using ForumPlusPlus.Models.ForumViewModels;
using ForumPP.DataAccess;
using System.Linq;
using ForumPlusPlus.Models.PostViewModels;

namespace ForumPlusPlus.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;

        public HomeController(IPost postService, IForum forumService) 
        {
            _postService = postService;
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            var latestPosts = _postService.GetLatestPosts(5);
            var latestForums = _forumService.GetLatestForums(5);

            var latestForumsMapped = latestForums.Select(f => new ForumViewModel
            {
                Id = f.Id,
                Description = f.Description,
                ImageUrl = f.ImageUrl,
                Name = f.Title,
                UserId = f.User.Id,
                UserName = f.User.UserName,
                UserRating = f.User.Rating,
                Created = f.Created,
                PostsCount = f.Posts.Count()
            });

            var latestPostsMaped = latestPosts.Select(p => new PostViewModel
            {
                Id = p.Id,
                Title = p.Title,
                AuthorId = p.User.Id,
                AuthorName = p.User.UserName,
                AuthorRating = p.User.Rating,
                DatePosted=p.Created.ToString(),
                RepliesCount= p.Replies.Count(),
                Forum = new ForumViewModel 
                {
                    Id = p.Forum.Id,
                    Name=p.Forum.Title,
                    ImageUrl=p.Forum.ImageUrl
                }
            });

            var model = new ForumIndexModel()
            {
                LatestPosts = latestPostsMaped,
                ForumViewModels= latestForumsMapped
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
