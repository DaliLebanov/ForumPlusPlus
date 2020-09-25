using ForumPP.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumPP.DataAccess
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        
        IEnumerable<Post> GetForumPosts(int forumId);
        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        IEnumerable<Post> GetLatestPosts(int n);
        IEnumerable<Post> GetSeacrhedPosts(Forum forum, string searchQuery);
        IEnumerable<Post> FromAllSearchedPosts(string searchQuery);
    }
}
