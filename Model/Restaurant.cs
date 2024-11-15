
namespace Model
{
    public class Restaurant
    {
        public DiningRoom diningRoom { get; private set; } = new DiningRoom();
        public Kitchen kitchen { get; private set; } = new Kitchen();

        public DiningRoom getDiningRoom() => diningRoom;
        public Kitchen getKitchen() => kitchen;
    }
}
