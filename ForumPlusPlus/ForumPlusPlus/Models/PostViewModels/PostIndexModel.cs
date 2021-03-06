﻿using ForumPlusPlus.Models.ReplyViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumPlusPlus.Models.PostViewModels
{
    public class PostIndexModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int AuthorRating { get; set; }
        public string AuthorImageUrl { get; set; }
        public DateTime Created { get; set; }
        public string PostContent { get; set; }
        public int ForumId { get; set; }
        public string ForumTopic { get; set; }
        public bool IsAuthorAdmin { get; set; }

        public IEnumerable<PostReplyViewModel> Replies{ get; set; }
    }
}
