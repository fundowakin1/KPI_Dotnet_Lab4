using Lab4.Flowers;

namespace Lab4.Bouquets
{
    public interface IBouquet
    {
        public void Add(Flower flower);
        public decimal Price { get; }
    }
}
