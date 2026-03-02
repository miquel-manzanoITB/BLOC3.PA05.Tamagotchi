
namespace BLOC3.PA05.Tamagotchi.Models
{
    public class Stats
    {
        private int healthLevel;
        public int HealthLevel
        {
            get => healthLevel;
            set => healthLevel = Math.Clamp(value, 0, 100);
        }

        private int energyLevel;
        public int EnergyLevel
        {
            get => energyLevel;
            set => energyLevel = Math.Clamp(value, 0, 100);
        }
        private int hungryLevel;
        public int HungryLevel
        {
            get => hungryLevel;
            set => hungryLevel = Math.Clamp(value, 0, 100);
        }

        public Stats()
        {
            HealthLevel = 100;
            EnergyLevel = 100;
            HungryLevel = 100;
        }
        public void AddHealth(int amount) => HealthLevel += amount;
        public void AddEnergy(int amount) => EnergyLevel += amount;
        public void AddHungry(int amount) => HungryLevel += amount;
        public void RemoveHealth(int amount) => HealthLevel -= amount;
        public void RemoveEnergy(int amount) => EnergyLevel -= amount;
        public void RemoveHungry(int amount) => HungryLevel -= amount;
    }
}
