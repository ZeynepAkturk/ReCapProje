using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleKatman
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
              foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
