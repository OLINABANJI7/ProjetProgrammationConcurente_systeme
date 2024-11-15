
namespace Model
{
    public class Client
    {
        public ClientBehaviourStrategy behavior { get; set; }
        public Table table;

        public Order placeOrder()
        {
            return new OrderFactory().createOrder(this);
        }

        public void requestAssistance()
        {
            behavior.behave();
        }
    }
}
