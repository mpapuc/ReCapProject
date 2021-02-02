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
                new Car {BrandId = 1, ColorId = 1, DailyPrice =700, Id = 1, ModelYear = 2020, Description = "SunRoof"},
                new Car {BrandId = 1, ColorId = 4, DailyPrice =500, Id = 2, ModelYear = 2015, Description = "Hatchback"},
                new Car {BrandId = 2, ColorId = 2, DailyPrice =800, Id = 3, ModelYear = 2018, Description = "SUV"},
                new Car {BrandId = 3, ColorId = 3, DailyPrice =750, Id = 4, ModelYear = 2020, Description = "SunRoof"},
                new Car {BrandId = 4, ColorId = 2, DailyPrice =700, Id = 5, ModelYear = 2019, Description = "Cabrio"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id );
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
