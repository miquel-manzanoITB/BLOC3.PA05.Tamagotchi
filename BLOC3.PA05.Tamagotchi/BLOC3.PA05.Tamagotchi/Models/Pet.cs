
using BLOC3.PA05.Tamagotchi.Models.Enumerations;

namespace BLOC3.PA05.Tamagotchi.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public EmotionState Emotion { get; set; }
        public bool IsDead { get; set; }
        public Stats PetStats { get; set; } = new Stats();

        public Pet(string name, EmotionState emotion)
        {
            Name = name;
            Emotion = emotion;
            IsDead = false;
        }

        public Pet(string name, EmotionState emotion, bool isDead)
        { 
            Name = name;
            Emotion = emotion;
            IsDead = isDead;
        }
    }
}
