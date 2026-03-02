
namespace BLOC3.PA05.Tamagotchi.Models
{
    public class Food : Item
    {
        public int NutritionalValue { get; set; }

        public Food (int nutritionalValue, string name) : base(name)
        {
            NutritionalValue = nutritionalValue;
        }
    }
}
