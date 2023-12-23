using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Bike : IVehicle
    {
        private readonly int weels;
        public Bike()
        {
            this.weels = 2;
        }
        public int NumOfWeels()
        {
            return this.weels;
        }

        public string VehicleType()
        {
            return "Bike";
        }
    }
}
