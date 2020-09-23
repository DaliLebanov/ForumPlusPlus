using ForumPlusPlus.Models.PostViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumPlusPlus.Models.ForumViewModels
{
    public class ForumIndexModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<ForumViewModel> ForumViewModels { get; set; }
        public IEnumerable<PostViewModel> LatestPosts { get; set; }
    }
}
