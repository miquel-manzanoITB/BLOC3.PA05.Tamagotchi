using BLOC3.PA05.Tamagotchi.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLOC3.PA05.Tamagotchi.Models
{
    public class NonAnimal : Pet
    {
        public NonAnimal(string name, EmotionState emotion) : base(name, emotion)
        {

        }
    }
}
