using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string vehicleType = null;
            Console.WriteLine("Enter Vehicle Type");
            vehicleType = Console.ReadLine();
            IVehicle type = VehicleFactoryOne.getVehicle(vehicleType);
            Console.WriteLine("Type is :" + type.VehicleType());
            Console.WriteLine("Number of Weels" + type.NumOfWeels());
            Console.ReadKey();

        }
    }
}
