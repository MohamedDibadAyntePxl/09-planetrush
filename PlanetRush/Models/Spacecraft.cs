using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    public class Spacecraft
    {
        public string Name { get; set; }
        public int FuelCapacity { get; set; }
        public int EngineEfficiency { get; set; }
        public int CargoCapacity { get; set; }
        public bool HasWarpDriveCharge { get; set; }

        public Spacecraft()
        {
            FuelCapacity = 1000;
            CargoCapacity = 1000;
            EngineEfficiency = 10;
            HasWarpDriveCharge = false;
        }
    }
}
