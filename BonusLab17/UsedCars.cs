using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab17
{
    class UsedCars : Cars
    {
        private double carMileage;

        public double CarMileage
        {
            set { carMileage = value; }
            get { return carMileage; }
        }

        public UsedCars()
        {
            carMileage = 3000.00;
        }

        public UsedCars(string uMake, string uModel, int uYear, double uPrice, double uMiles):base(uMake,uModel,uYear,uPrice)
        {
            CarMileage = uMiles;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($"{CarMileage}");
        }

    }
}
