using EntityLayer1;
using EntityLayer1.Concreate;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //Bu context sınıfı  tabloların veritabanına yansıtıldığı kısım.
        public DbSet<About> Abouts { get; set; }//<> içindeki aboutu kullanabilmek için reference vermemiz gerekir.Abouts kısmı veritabanına yansıyacak kıısm
        public DbSet <Category>Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Draft> Drafts { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
