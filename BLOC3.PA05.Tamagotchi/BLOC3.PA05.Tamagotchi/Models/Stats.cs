using System;
using System.Collections.Generic;
using System.Text;

namespace BLOC3.PA05.Tamagotchi.Models
{
    public class Stats
    {
        public int HealthLevel { get; set; }
        public int EnergyLevel { get; set; }
        public int HungryLevel { get; set; }

        public Stats()
        {
            HealthLevel = 100;
            EnergyLevel = 100;
            HungryLevel = 100;
        }
    }
}
