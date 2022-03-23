using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
   public class Taxi
    {
        // properties 
        public string DriverName { get; set; }
        public bool Onduty { get; set; }
        bool duty = true;
        public int NumPassenger { get; set; }

        // methode
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", duty ? "yes" : "No");
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
            Console.WriteLine();
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang", DriverName);
        }
    }
}
