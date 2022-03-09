using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;    //Bu objenin türü DbSet olacak.

        public void Delete(Category p)
        {
            _object.Remove(p); //Bir şeyi kaldıracaksın. Neyi? parametreden gelen değeri.
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p); //Neyi ekleyeceksin? parametreden gelen değeri benim _object içerisinde bulunan sınıfıma ekle.Yani Category'e.
            c.SaveChanges(); //Context de değişiklikleri kaydet.(değişiklikler veritabanına yansıtılsın.)
        }

        public List<Category> List()
        {
            return _object.ToList();    //_object den gelen ifadeyi ToList() metodu ile listeleyecek.
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges(); //Yapacağım tek şey direkt olarak değişiklikleri kaydetmek
        }
    }
}
