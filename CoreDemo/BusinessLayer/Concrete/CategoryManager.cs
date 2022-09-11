using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //GenericRepository<Category> _repo=new GenericRepository<Category>;
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
           
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
           return efCategoryRepository.Get(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetAll();
        }
    }
}
