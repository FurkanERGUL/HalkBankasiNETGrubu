﻿using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Interfaces
{
    public interface ICategoryRepo : IBaseRepo<Category>
    {
        List<Category> CategoryFindByName(string categoryName);
    }
}
