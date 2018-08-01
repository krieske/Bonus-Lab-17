 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab17
{
    class Program
    {
        static void Main(string[] args)
        {

            Cars car1 = new Cars("Car Make", "Car Model", 2018, 2000);

            Cars car2 = new Cars("Car Make", "Car Model", 2000, 5000);

            Cars car3 = new Cars("Car Make", "Car Model", 2005, 67000);

            UsedCars car4 = new UsedCars("Car Make", "Car Model", 4013, 1080, 3000);

            UsedCars car5 = new UsedCars("Car Make", "Car Model", 3200, 4000, 56000);

            UsedCars car6 = new UsedCars("Car Make", "Car Model", 2064, 15000, 2034);

            List<Cars> cars = new List<Cars>() {car1, car2, car3, car4, car5, car6 };



            foreach (Cars car in cars)
            {
                car.PrintInfo();
            }

            //string playAgain = "yes";

            //while (playAgain == "yes")
            //{
            //    Console.WriteLine("Please pick a number to view more information on car.");
            //    int userChoice = int.Parse(Console.ReadLine());


            Console.WriteLine("tttttttttttttttttttttttttttttttttttt"); 
                
                cars.RemoveAt(0);
                foreach (Cars car in cars)
                {
                    car.PrintInfo();
                }

           
        }
    }
}
