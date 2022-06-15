using Lab4.Bouquets;
using Lab4.Decorations;

namespace Lab4.Decorators
{
    public class BasketDecorator : BaseDecorator
    {
        public BasketDecorator(IBouquet bouquet) : base(bouquet)
        {
            _decoration = new Basket();
        }

    }
}
