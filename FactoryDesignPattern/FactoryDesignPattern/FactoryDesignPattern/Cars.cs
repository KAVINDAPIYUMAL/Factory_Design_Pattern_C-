using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Cars : IVehicle
    {
        private readonly int weels;
        public Cars()
        {
            this.weels = 4;
        }
        public int NumOfWeels()
        {
            return this.weels;
        }

        public string VehicleType()
        {
            return "Cars";
        }
    }
}
