using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BookStore.Repository.Interfaces
{
    public interface IBookRepo: IBaseRepo<Book>
    {
        List<Book> BookFindByName(string bookName);
    }
}
