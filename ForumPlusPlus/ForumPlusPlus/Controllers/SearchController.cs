using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumPlusPlus.Models.ForumViewModels;
using ForumPlusPlus.Models.PostViewModels;
using ForumPlusPlus.Models.SearchViewModels;
using ForumPP.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace ForumPlusPlus.Controllers
{
    public class SearchController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;

        public SearchController(IForum forumService, IPost postService)
        {
            _forumService = forumService;
            _postService = postService;
        }
        
        public IActionResult Results(string searchQuery)
        {
            var posts = _postService.FromAllSearchedPosts(searchQuery);
            var areNoResults = (!string.IsNullOrEmpty(searchQuery) && !posts.Any());
            var postViewModels = posts.Select(post => new PostViewModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                AuthorName = post.User.UserName,
                Title = post.Title,
                DatePosted = post.Created.ToString("dd/MM/yyyy"),
                RepliesCount = post.Replies.Count(),
                Forum = new ForumViewModel
                {
                    Id = post.Forum.Id,
                    Name = post.Forum.Title,
                    ImageUrl = post.Forum.ImageUrl,
                    Description = post.Forum.Description
                }
            });
            var model = new SearchResultModel
            {
                Posts = postViewModels,
                SearchQuery = searchQuery,
                EmptySearchQuery = areNoResults
            };
            return View(model);

        }

        [HttpPost]
        public IActionResult Search(string searchQuery) 
        {
            return RedirectToAction("Results", new { searchQuery });
        }
    }
}
