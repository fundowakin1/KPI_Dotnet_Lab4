using System.Text;
using Lab4.Flowers;

namespace Lab4.Bouquets
{
    public class Bouquet : IBouquet
    {
        public List<Flower> Flowers { get; } = new List<Flower>();
        public decimal Price => !Flowers.Any() ? 0 : Flowers.Select(x => x.Price).Sum();
        public void Add(Flower item)
        {
            Flowers.Add(item);
        }
        public override string ToString()
        {
            var result = new StringBuilder("The bouquet consists of:\n\n");
            foreach (var flower in Flowers)
            {
                result.AppendLine($"{flower.Name} for {flower.Price}");
            }

            result.AppendLine($"\nThe bouquet cost is {Price}");
            return result.ToString();
        }
    }
}
