
namespace Model
{
    public class Kitchen
    {
        public Chef chef { get; set; }
        public Stock stock { get; private set; } = Stock.GetInstance();

        public void prepareOrder(Order order)
        {
            chef.dispatchOrders();
        }

        public void manageStock()
        {
            // stock.updateStock();
        }
    }
}
