

namespace Model
{
    public class ExtraSpiceDecorator : OrderDecorator
    {
        public ExtraSpiceDecorator(Order order) : base(order) { }
        public override void addFeature()
        {
            // Add extra spice feature
        }
}
}
