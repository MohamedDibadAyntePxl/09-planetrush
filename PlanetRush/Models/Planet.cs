using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    public class Planet
    {
        public int Radius { get; set; }
        public int Seed { get; set; }
        public string Name { get; set; }
        public int TonsOfRawAetherium { get; set; }
        public int TonsOfTrilliumAlloys { get; set; }
        public bool NeedsTerraforming { get; set; }
        public bool NeedsGenestealing { get; set; }
        public bool NeedsNuking { get; set; }
        public int NumberOfLightYearsToReach { get; set; }

        public int ResourceDensity
        {
            get { return(TonsOfRawAetherium + TonsOfTrilliumAlloys) / 10; }
        }
        private Random rng = new Random();
        public Planet() : this(0)
        {

        }
        public Planet(int galaxyCode)
        {

        }

    }
}
