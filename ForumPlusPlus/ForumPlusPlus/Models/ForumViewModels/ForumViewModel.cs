using ForumPlusPlus.Models.PostViewModels;
using ForumPP.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumPlusPlus.Models.ForumViewModels
{
    public class ForumViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int PostsCount { get; set; }
    }
}
