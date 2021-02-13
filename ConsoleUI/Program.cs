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
            //CarManagerTest();

            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.FirstName +"/"+ item.LastName);
            }

            Console.ReadLine();
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("*********************************");
                    Console.WriteLine(" Araba Adı: " + item.CarName + "\n" + " Marka Adı: " + item.BrandName + "\n" + " Fiyat :" + item.DailyPrice + " \n" + " Renk: " + item.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
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
