using BLOC3.PA05.Tamagotchi.Models.Enumerations;
using BLOC3.PA05.Tamagotchi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLOC3.PA05.Tamagotchi.Models
{
    public class Animal : Pet, IPlay, ISleep, IEat
    {
        public Animal(string name, EmotionState emotion) : base(name, emotion)
        {

        }

        public void Eat()
        {
            PetStats.RemoveHungry(20);
            PetStats.AddEnergy(10);
        }

        public void Play()
        {
            PetStats.RemoveEnergy(20);
            Emotion = EmotionState.Happy;
        }

        public void Sleep() => PetStats.AddEnergy(100);
    }
}
