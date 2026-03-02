
namespace BLOC3.PA05.Tamagotchi.Models
{
    public abstract class Item
    {
        public string Name { get; set; }
        
        public Item(string name)
        {
            Name = name;
        }
    }
}
