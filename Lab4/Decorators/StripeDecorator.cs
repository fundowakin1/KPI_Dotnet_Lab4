using Lab4.Bouquets;
using Lab4.Decorations;

namespace Lab4.Decorators
{
    public class StripeDecorator : BaseDecorator
    {
        public StripeDecorator(IBouquet bouquet) : base(bouquet)
        {
            _decoration = new Stripe();
        }
    }
}
