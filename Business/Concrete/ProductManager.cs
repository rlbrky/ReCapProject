using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        //Bir adet IProductDal referansı alıyoruz, böylece herhangi bir referansta veritabanında çalışabileceğiz.
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Car> GetAll()
        {
            //İş kodları ve YetkiKontrolü
            return _productDal.GetAll();
        }
    }
}
