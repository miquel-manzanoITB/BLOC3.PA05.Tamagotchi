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

        public void Eat(Food food)
        {
            PetStats.RemoveHungry(food.NutritionalValue);
            PetStats.AddEnergy(food.NutritionalValue);
        }

        public void Play()
        {
            PetStats.RemoveEnergy(20);
            Emotion = EmotionState.Happy;
        }

        public void Sleep() => PetStats.AddEnergy(100);
    }
}
