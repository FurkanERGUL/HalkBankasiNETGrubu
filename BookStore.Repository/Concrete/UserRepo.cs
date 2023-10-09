using BookStore.Core.Entities;
using BookStore.Repository.Contexts;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Concrete
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        private readonly AppDbContext _context;
        public UserRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<User> UserFindByName(string userName)
        {
            var liste = _context.Users.Where(x=> x.UserName == userName).ToList();
            return liste;
        }
    }
}
