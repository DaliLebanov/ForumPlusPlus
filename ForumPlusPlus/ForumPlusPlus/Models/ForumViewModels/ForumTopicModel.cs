using ForumPlusPlus.Models.PostViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumPlusPlus.Models.ForumViewModels
{
    public class ForumTopicModel
    {
        public string SearchQuery { get; set; }
        public ForumViewModel Forum { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}
