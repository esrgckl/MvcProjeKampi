using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
        ////CRUD
        ////Type Name();

        ////ilk metodum listeleme.
        //List<Category> List();  //Türü List olan, ismi de List olan bir metot

        //void Insert(Category p);    //Ekleme

        //void Update(Category p);

        //void Delete(Category p);


    }
}
