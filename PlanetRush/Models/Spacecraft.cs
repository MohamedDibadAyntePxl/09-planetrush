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
        private int _CurrentFuel;
        public int CurrentFuel
        {
            get { return _CurrentFuel; }
            set { _CurrentFuel = Math.Min(value, FuelCapacity); }
        }

        public Spacecraft()
        {
            FuelCapacity = 1000;
            CargoCapacity = 1000;
            EngineEfficiency = 10;
            HasWarpDriveCharge = false;
            CurrentFuel = FuelCapacity;
        }
    }
}
