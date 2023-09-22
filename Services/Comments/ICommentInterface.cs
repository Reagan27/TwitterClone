using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;
using TwitterClone.Models;

namespace TwitterClone.Services.Comments
{
    public interface ICommentInterface
    {
        Task<List<Comment>> GetCommentsAsync();
        Task<List<Comment>> GetCommentsByPostAsync(int id);

    }
}