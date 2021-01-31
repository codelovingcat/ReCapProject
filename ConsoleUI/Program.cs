using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka : " + car.BrandId);
                Console.WriteLine("Açıklama : " + car.Description);
                Console.WriteLine("Fiyatı : " + car.DailyPrice);
                Console.WriteLine("Model yılı : " + car.ModelYear);
                Console.WriteLine("***************************************************************");
            }
            Console.ReadLine();
        }
    }
}
