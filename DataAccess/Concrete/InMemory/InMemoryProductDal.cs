using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=300,Description="1.6TSI Passat"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2020,DailyPrice=500,Description="1.6TDI Caddy"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=1000,Description="A3 Sedan 1.6TDI"},
                new Car{Id=4,BrandId=2,ColorId=1,ModelYear=2021,DailyPrice=1800,Description="A5 Sportback 40 TDI"},
                new Car{Id=5,BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=1450,Description="A4 Sedan Sport"},
                new Car{Id=6,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=2500,Description="E 200D Exclusive"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToRemove = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToRemove);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
