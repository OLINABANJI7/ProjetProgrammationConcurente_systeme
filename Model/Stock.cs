
namespace Model
{
    public class Stock
    {
        private static Stock ?instance;
        public Dictionary<string, int> ingredients { get; private set; } = new Dictionary<string, int>();

        private Stock() { }

        public static Stock GetInstance()
        {
            if (instance == null)
            {
                instance = new Stock();
            }
            return instance;
        }

        public void updateStock(String product, int quantity)
        {
            // Code to update stock
        }

        public bool checkAvailability(string ingredient, int quantity)
        {
            return ingredients.ContainsKey(ingredient) && ingredients[ingredient] >= quantity;
        }
    }
}
