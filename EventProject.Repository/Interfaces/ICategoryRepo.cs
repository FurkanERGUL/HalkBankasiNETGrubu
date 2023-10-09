using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Interfaces
{
    public interface ICategoryRepo: IBaseRepo<Category>
    {
        int GetEventCountByCategory(int categoryId);
    }
}
