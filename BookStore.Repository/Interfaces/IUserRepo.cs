using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Interfaces
{
    public interface IUserRepo : IBaseRepo<User>
    {
        List<User> UserFindByName(string userName);
    }
}
