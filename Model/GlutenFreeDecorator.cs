

namespace Model
{
    public class GlutenFreeDecorator : OrderDecorator
    {
        public GlutenFreeDecorator(Order order) : base(order) { }

        public override void addFeature()
        {
            // Add gluten-free feature
        }
    }
}
