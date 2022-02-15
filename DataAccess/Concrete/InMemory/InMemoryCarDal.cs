using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=30000, Description="Mercedes", ModelYear="2020"},
                new Car{Id=2, BrandId=2, ColorId=1, DailyPrice=25000, Description="Fiat", ModelYear="2019"},
                new Car{Id=3, BrandId=3, ColorId=2, DailyPrice=20000, Description="Tofaş", ModelYear="2018"},
            };
        }

        void ICarDal.Add(Car car)
        {
            _cars.Add(car);
        }

        void ICarDal.Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        List<Car> ICarDal.GetAll()
        {
            return _cars;
        }

        void ICarDal.Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
