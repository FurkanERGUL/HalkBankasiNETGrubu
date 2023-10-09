using EventProject.Core.Entities;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concrete
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        private readonly AppDbContext _context;
        public CategoryRepo(AppDbContext context) : base(context)
        {
            _context= context;
        }

        public int GetEventCountByCategory(int categoryId)
        {
            return _context.Events.Count(e=>e.CategoryId==categoryId);
        }
    }
}
