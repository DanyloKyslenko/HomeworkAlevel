using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class VehicleBase : IVehicle
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public double Weight { get; set; }
        public string Area { get; set; }
        public VehicleBase(string model, string area, int speed, double weight)
        {
            Model = model;
            Area = area;
            Speed = speed;
            Weight = weight;
        }
        public abstract void PrintStats();
    }
}
