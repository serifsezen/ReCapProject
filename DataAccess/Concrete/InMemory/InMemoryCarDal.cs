using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=200,Description="Toyota Corolla 1.4 D4D Comfort Manuel" },
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear=2018,DailyPrice=250,Description="Seat Leon FR 1.6 Automatic" },
                new Car{Id=3,BrandId=1,ColorId=2,ModelYear=2019,DailyPrice=300,Description="Renault Megane 4 1.4 Icon Automatic" },
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear=2016,DailyPrice=225,Description="Honda Civic 1.6 Automatic" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
           return _cars.Where(c => c.Id ==id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
