using BookStore.Core.Entities;
using BookStore.Repository.Contexts;
using BookStore.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Concrete
{
    public class AuthorRepo : BaseRepo<Author>, IAuthorRepo
    {
        private readonly AppDbContext _context;
        public AuthorRepo(AppDbContext context) : base(context)
        {
            _context= context;
        }

        public List<Author> AuthorFindByName(string authorName)
        {
            var liste = _context.Authors.Where(x => x.AuthorName == authorName).ToList();
            return liste;
        }
    }
}
