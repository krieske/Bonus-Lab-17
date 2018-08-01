using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab17
{
    class Cars
    {
        private string carMake;
        private string carModel;
        private int carYear;
        private double carPrice;


        public string CarMake
        {
            set { carMake = value; }
            get { return carMake; }
        }

        public string CarModel
        {
            set { carModel = value; }
            get { return carModel; }
        }

        public int CarYear
        {
            set { carYear = value; }
            get { return carYear; }
        }

        public double CarPrice
        {
            set { carPrice = value; }
            get { return carPrice; }
        }

        public Cars()
        {
            CarMake = "not assigned";
            CarModel = "not assigned";
            CarYear = 2000;
            CarPrice = 1000.00;
        }

        public Cars(string cMake, string cModel, int cYear, double cPrice)
        {
            CarMake = cMake;
            CarModel = cModel;
            CarYear = cYear;
            CarPrice = cPrice;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{CarMake}, {CarModel}, {CarYear}, {CarPrice} ");
        }
    }
}
