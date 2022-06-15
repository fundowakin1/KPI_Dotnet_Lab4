using Lab4.Bouquets;

namespace Lab4.Builders
{
    public interface IBouquetBuilder
    {
        public void BuildRose(int quantity);
        public void BuildTulip(int quantity);
        public void BuildViolet(int quantity);
        public Bouquet GetBouquet();
    }
}
