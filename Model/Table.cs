
namespace Model
{
    public class Table(int id, int seats, bool isAvailable = true)

    {
        public int id { get; set; } = id;
        public int seats { get; set; } = seats;
        public bool isAvailable { get; private set; } = isAvailable;

        public void reserve()
        {
            isAvailable = false;
        }

        public void free()
        {
            isAvailable = true;
        }
    }
}
