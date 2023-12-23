using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class VehicleFactoryOne
    {
        public static IVehicle getVehicle(string type)
        {
            IVehicle objectType = null;
            if (type.ToLower().Equals("bike"))
            {
                objectType = new Bike();
            }
            else if (type.ToLower().Equals("cars"))
            {
                objectType = new Cars();
            }
            return objectType;
        }
    }
}
