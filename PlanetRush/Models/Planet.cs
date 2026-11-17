using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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
            Radius = rng.Next(4, 14);
            Seed = rng.Next();
            Name = GeneratePlanetCode(galaxyCode);
            TonsOfRawAetherium = rng.Next(10, 111);
            TonsOfTrilliumAlloys = rng.Next(-10, 31);
            if (TonsOfTrilliumAlloys < 0)               // is het negatief?
            {
                TonsOfTrilliumAlloys = 0;               // dan wordt het 0
            }
            // Andere manier, in 1 regel:
            // TonsOfTrilliumAlloys = Math.Max(0, rng.Next(-10, 31));   // Max = nooit lager dan 0
            NumberOfLightYearsToReach = rng.Next(5, 21);
            ConfigureCorrectOption();
        }
        private void ConfigureCorrectOption()
        {
            int option = rng.Next(3);
            switch (option)
            {
                case 0:
                    NeedsTerraforming = true;
                    break;
                case 1:
                    NeedsGenestealing = true;
                    break;
                case 2:
                    NeedsNuking = true;
                    break;
            }
        }
        
        private string GeneratePlanetCode(int galaxyCode = 0)
        {
            string choice;
            
            if (galaxyCode == 1)
            {
                choice  = "M31";
                
            }
            else if (galaxyCode == 2)
            {
                choice = "M33";
            }
            else
            {
                choice = "MW";
            }
            char letter = (char) rng.Next('A', 'Z' + 1);
            char letter2 = (char) rng.Next('A', 'Z' + 1);
            int number = rng.Next(1000, 10000);
            string prefix = $"{choice}-{letter}{letter2}-{number}";
            return prefix;      
        
        }
       
    }
}
