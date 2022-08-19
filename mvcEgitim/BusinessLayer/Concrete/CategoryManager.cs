using BusinessLayer.Concrete.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService//Categori arabirim  den miras aldık.
    {


        ICategoryDal _CategoryDal;//Bu bir fielddir.

       

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _CategoryDal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _CategoryDal.List();
        }
        public void CategoryAddBL(Category category)
        {
            _CategoryDal.Insert(category);
        }

        public Category GetById(int id)
        {
            return _CategoryDal.Get(x => x.CategoryId == id);
        }

        public void CategoryDelete(Category category)
        {
            _CategoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _CategoryDal.Update(category);
        }
    }
}
