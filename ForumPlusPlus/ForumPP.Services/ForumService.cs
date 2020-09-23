using ForumPlusPlus.DataAccess;
using ForumPP.DataAccess;
using ForumPP.DataAccess.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumPP.Services
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums.Include(f=> f.Posts) ;
        }

        public IEnumerable<User> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int Id)
        {

            var forum = _context.Forums.Where(f => f.Id == Id)
                 .Include(f => f.Posts)
                     .ThenInclude(p => p.User)
                 .Include(f => f.Posts)
                     .ThenInclude(p => p.Replies)
                        .ThenInclude(r => r.User)
                 .FirstOrDefault();

            return forum;
        }

        public IEnumerable<Forum> GetLatestForums(int n)
        {
            return GetAll().OrderByDescending(f => f.Posts.Count()).Take(10);
        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
