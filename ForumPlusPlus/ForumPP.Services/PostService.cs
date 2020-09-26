using ForumPlusPlus.DataAccess;
using ForumPP.DataAccess;
using ForumPP.DataAccess.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumPP.Services
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();

        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                .Include(p => p.User)
                .Include(p => p.Replies)
                     .ThenInclude(p => p.User)
                .Include(p => p.Forum);
        }

        public Post GetById(int id)
        {
            return _context.Posts
                 .Include(p => p.User)
                 .Include(p => p.Replies)
                     .ThenInclude(p => p.User)
                 .Include(p => p.Forum)
                 .First(f => f.Id == id);
        }

       

        public IEnumerable<Post> GetForumPosts(int forumId)
        {
            return _context.Forums.FirstOrDefault(f => f.Id == forumId).Posts;
        }

        public IEnumerable<Post> GetLatestPosts(int n)
        {
            return GetAll().OrderByDescending(p => p.Created).Take(n);
        }

        public IEnumerable<Post> GetSeacrhedPosts(Forum forum, string searchQuery)
        {
            return string.IsNullOrEmpty(searchQuery)
                ? forum.Posts
                : forum.Posts.Where(p
                    => p.Title.Contains(searchQuery)
                    || p.Content.Contains(searchQuery));
        }

        public IEnumerable<Post> FromAllSearchedPosts(string searchQuery)
        {
            return GetAll().Where(p => p.Title.Contains(searchQuery) 
                                        ||
                                       p.Content.Contains(searchQuery));
        }

        public int AddReply(PostReply reply)
        {
            _context.PostReplies.Add(reply);
            return _context.SaveChanges();
        }
    }
}
