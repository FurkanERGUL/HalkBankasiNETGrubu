using EventProject.Core.Entities;
using EventProject.Core.Enums;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _repo;
        public CategoryService(ICategoryRepo repo)
        {
            _repo= repo;
        }
        public bool Any(Expression<Func<Category, bool>> expression)
        {
            return _repo.Any(expression);
        }

        //Başlangıç hatası alıyoruz.
        public void Create(Category Entity)
        {
            if (Any(x=>x.CategoryName.ToLower()!=Entity.CategoryName.ToLower()))
            {
                _repo.Create(Entity);
            }
            else
            {
                throw new Exception("Zaten mevcut!!");
            }
        }

        public void Delete(Category Entity)
        {
            if (GetDefaultById(Entity.Id)!=null)
            {
                Entity.DeleteDate = DateTime.Now;
                Entity.Status = Status.Passive;
                _repo.Delete(Entity);
            }
            else
            {
                throw new Exception("Hata!");
            }
        }

        public Category GetDefault(Expression<Func<Category, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Category GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Category> GetDefaults(Expression<Func<Category, bool>> expression)
        {
            return _repo.GetDefaults(expression).Where(c=>c.Status!=Core.Enums.Status.Passive).ToList();
        }

        public int GetEventCountByCategory(int categoryId)
        {
            return _repo.GetEventCountByCategory(categoryId);
        }

        public void Update(Category Entity)
        {
            Entity.UpdateDate= DateTime.Now;
            Entity.Status= Status.Modified;
            _repo.Update(Entity);
        }
    }
}
