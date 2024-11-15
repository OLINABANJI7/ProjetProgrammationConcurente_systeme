namespace Model
{
    public abstract class OrderDecorator : Order
    {
        protected Order order;

        public OrderDecorator(Order _order)
        {
            order = _order;
        }

        public abstract void addFeature();
    }
}
