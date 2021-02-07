using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine("*********************************");
                Console.WriteLine(" Araba Adı: "+ item.CarName+"\n" + " Marka Adı: "+ item.BrandName + "\n" + " Fiyat :" + item.DailyPrice+ " \n" + " Renk: "+ item.ColorName);
            }
            Console.ReadLine();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka : " + car.BrandId);
                Console.WriteLine("Açıklama : " + car.Description);
                Console.WriteLine("Fiyatı : " + car.DailyPrice);
                Console.WriteLine("Model yılı : " + car.ModelYear);
                Console.WriteLine("***************************************************************");
            }
        }
    }
}
