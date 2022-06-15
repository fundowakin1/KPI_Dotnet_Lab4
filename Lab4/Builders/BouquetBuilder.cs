using Lab4.Bouquets;
using Lab4.Flowers;

namespace Lab4.Builders
{
    public class BouquetBuilder : IBouquetBuilder
    {
        private Bouquet _bouquet = new Bouquet();

        public BouquetBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _bouquet = new Bouquet();
        }

        public void BuildRose(int quantity)
        {
            for(var i = 0; i < quantity; i++)
                _bouquet.Add(new Rose());
        }

        public void BuildTulip(int quantity)
        {
            for (var i = 0; i < quantity; i++)
                _bouquet.Add(new Tulip());
        }

        public void BuildViolet(int quantity)
        {
            for (var i = 0; i < quantity; i++)
                _bouquet.Add(new Violet());
        }

        public Bouquet GetBouquet()
        {
            var result = _bouquet;
            Reset();
            return result;
        }
    }
}
