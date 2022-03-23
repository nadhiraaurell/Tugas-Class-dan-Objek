using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat object Taxi
            Taxi taxi = new Taxi();

            // pengetesan nilai properties
            taxi.DriverName = "Jono";
            taxi.Onduty = true;
            taxi.NumPassenger = 10;

            // pemanggilan methode Taxi Info, Pick Up Passenger, dan Drop Off Passenger
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
