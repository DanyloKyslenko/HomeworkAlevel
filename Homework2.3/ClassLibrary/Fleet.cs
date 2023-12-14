using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Fleet
    {
        private List<VehicleBase> vehicles = new List<VehicleBase>();

        public void AddVehicle(VehicleBase vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void RemoveVehicle(VehicleBase vehicle)
        {
            if (vehicles.Contains(vehicle))
            {
                vehicles.Remove(vehicle);
            }
        }

        public List<VehicleBase> GetVehicles()
        {
            return vehicles;
        }
        public List<VehicleBase> SortBySpeed()

        {
            return vehicles.OrderBy(v => v.Speed).ToList();
        }
        public List<VehicleBase> SortByWeight()

        {
            return vehicles.OrderBy(m => m.Weight).ToList();
        }
    }
}
