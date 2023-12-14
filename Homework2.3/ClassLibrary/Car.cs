using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car : VehicleBase
    {
        public Car(string model, string area, int speed, double weight) : base(model, area, speed, weight)
        {
        }
        public override void PrintStats()
        {
            Console.WriteLine($"Vehicle: {Model} weighing {Weight} pounds , moves on {Area} at a speed {Speed} kilometers . ");
        }
    }
}
