
namespace BLOC3.PA05.Tamagotchi.Models
{
    public class Player
    {
        public string Name {  get; set; }
        public Inventory PlayerInventory { get; set; }
        public Pet? PlayersPet { get; set; }

        public Player(string name)
        {
            Name = name;
            PlayerInventory = new Inventory();
        }
    }
}
