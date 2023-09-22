using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;
using TwitterClone.Models;

namespace TwitterClone.Services.USers
{
    public interface IUserInterface
    {
        public Task<List<User>> GetUsersAsync();
    }
}