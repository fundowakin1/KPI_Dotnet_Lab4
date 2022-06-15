using Lab4.Bouquets;
using Lab4.Builders;

namespace Lab4.DirectorServices
{
    public class Director
    {
        private readonly IBouquetBuilder _builder;

        public Director(IBouquetBuilder builder)
        {
            _builder = builder;
        }
        public void BuildSimpleBouquet()
        {
            _builder.BuildRose(1);
            _builder.BuildTulip(1);
            _builder.BuildViolet(1);
        }

        public void BuildExpensiveBouquet()
        {
            _builder.BuildRose(3);
            _builder.BuildTulip(5);
            _builder.BuildViolet(10);
        }

        public void BuildSpringBouquet()
        {
            _builder.BuildTulip(3);
            _builder.BuildViolet(5);
        }

        public Bouquet GetBouquet()
        {
            return _builder.GetBouquet();
        }
    }
}
