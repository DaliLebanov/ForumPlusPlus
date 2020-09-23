using ForumPP.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumPP.DataAccess
{
    public interface IForum
    {
        Forum GetById(int Id);
        IEnumerable<Forum> GetAll();
        IEnumerable<User> GetAllActiveUsers();
        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
        IEnumerable<Forum> GetLatestForums(int n);
    }
}
