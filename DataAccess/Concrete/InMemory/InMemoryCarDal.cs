using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDAL
    {
        List<Car> _cars;
        // BrandId -> 1=TOYOTA 2= 3=OPEL
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=3, ColorId=2, DailyPrice=585.500, ModelYear= 2017, Description="2017 Opel Mokka X 1.6 CDTI 136HP EXCELLENCE AUT FWD" },
                new Car{Id=2, BrandId=1, ColorId=9, DailyPrice=824.900, ModelYear=2021, Description="2021 Toyota C-HR 1.8 HYBRID FLAME E-CVT 4X2"},
                new Car {Id=3, BrandId=1, ColorId=10, DailyPrice= 669.750, ModelYear=2020, Description="2020 Toyota Corolla Hybrid 1.8 HYBRID FLAME X-PACK E-CVT" },
                new Car {Id=4, BrandId=2, ColorId=5, DailyPrice=309.750, ModelYear=2018 , Description="2018 Fiat Egea 1.3 M.JET 95HP EASY" }



            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarToDelete);


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
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.Id = car.Id;
            CarToUpdate.BrandId = car.Id;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ColorId = car.ColorId;


        }
    }
}
