using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    public class Player
    {
        public Spacecraft Spacecraft { get; set; }
        public int TonsOfTrilliumAlloys { get; set; }
        public int TonsOfRawAetherium { get; set; }

        public int LitersOfFuel
        {
            get { return Spacecraft.CurrentFuel; }
        }
        public Player()
        {
            Spacecraft = new Spacecraft();
        }
        public void AddFuel(int fuel)
        {
            Spacecraft.CurrentFuel += fuel;
        }
        public void TravelLightYears(int lightYears)
        {
            Spacecraft.CurrentFuel -= lightYears * Spacecraft.EngineEfficiency ;
        }


    }
}
