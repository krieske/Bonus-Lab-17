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

            List<Cars> cars = new List<Cars>() { car1, car2, car3, car4, car5, car6 };

            string Continue = "y";
            while (Continue == "y")
            {
                // userinput for looking at cars goes HERE (if no = Continue = "n")

                foreach (Cars car in cars)
                {
                    car.PrintInfo();
                    Console.WriteLine();
                }

                // bool loopControl = LookAtCars();
                //string buyCar = "no";

                //Console.WriteLine("Would you like to look at some cars for purchase?");
                //string 



                //  while (loopControl)
                //  { 
                Console.WriteLine("Please pick a number to view more information on car.");
                int userChoice = ValidateCarRange(cars);
                Console.Clear();
                cars[userChoice - 1].PrintInfo();
                Console.WriteLine();

                Console.WriteLine("Would you like to purchase this car?");
                string userResponse = PurchaseCar();




                if (userResponse == "yes")
                {
                    cars.RemoveAt(userChoice - 1);

                    foreach (Cars car in cars)
                    {
                        car.PrintInfo();
                        Console.WriteLine();
                    }

                    Console.WriteLine("View more cars?");
                    if (Console.ReadLine() == "yes")
                    {
                        Continue = "y";
                    }
                    else
                    {
                        Continue = "n";
                    }
                }

                else
                {
                    Continue = "y";
                }
            }

            Console.WriteLine("Thanks for shopping!");
        }

        public static string ValidatePurchaseCar()
        {

            bool valid = false;
            string input = "";
            while (!valid)
            {
                try
                {

                    input = Console.ReadLine();
                    valid = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine("You did not enter a valid response.");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");

                }
            }
            return input;

            //string x = "y";
            //while (x == "y")
            //{
            //    if (userInput != "yes" && userInput != "no")
            //    {
            //        x = "y";
            //    }
            //    else if (userInput == "yes")
            //    {
            //        x = "n";
            //        return "yes";
            //    }
            //    else
            //    {
            //        x = "n";
            //        return "no";

            //    }
            //}
            //return "yes";
        }

        //public static bool LookAtCars()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Would you like to look at some cars for purchase? (yes/no)");
        //        string userInput = Console.ReadLine();

        //        if (userInput == "no")
        //        {
        //            return false;
        //        }
        //        else if (userInput == "yes")
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            Console.WriteLine("That is an invalid response.");
        //        }
        //    }
        //}

        public static int ValidateCarRange(List<Cars> c)
        {
            int min = 1;
            int max = 6;

            int num = ValidateCarNum();
            while ((num > max) || (num < min))
            {
                Console.WriteLine($"Please pick a number between 1 and {c.Count}.");
                num = ValidateCarNum();
            }
            return num;
        }

        public static int ValidateCarNum()
        {
            bool valid = false;
            int num = 0;
            while (!valid)
            {
                try
                {

                    num = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine("You did not enter a number.");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");

                }
            }
            return num;
        }

        public static string PurchaseCar()
        {
                string input = Console.ReadLine().ToLower();

                // input = ValidateUserString();
                while ((input != "yes") && (input != "y") && (input != "no") && (input != "n"))
                {
                    Console.WriteLine("Please either input yes or no.");
                    input = ValidatePurchaseCar();
                }

                return input;


                // if (userChoice == "no")
                //{
                //    return false;
                //}
                //else if (userChoice == "yes")
                //{
                //    return false;
                //}
                //else
                //{
                //    Console.WriteLine("That is an invalid response.");
                //    return true;
                //}
           

        }
    }
}
