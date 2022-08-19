﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _AboutDal;//Bu bir fielddir.

        public AboutManager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            _AboutDal.Insert(about);
        }

        public void AboutDelete(About about)
        {
            _AboutDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _AboutDal.Update(about);
        }

        public About GetById(int id)
        {
            return _AboutDal.Get(x => x.PublicId == id);
        }

        public List<About> GetList()
        {
            return _AboutDal.List();
        }
    }
}
