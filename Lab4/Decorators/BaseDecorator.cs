using System.Text;
using Lab4.Bouquets;
using Lab4.Decorations;
using Lab4.Flowers;

namespace Lab4.Decorators
{
    public abstract class BaseDecorator : IBouquet
    {
        protected IBouquet _bouquet;
        protected BaseDecoration _decoration;
        protected BaseDecorator(IBouquet bouquet)
        {
            _bouquet = bouquet;
        }
        public void Add(Flower item)
        {
            _bouquet.Add(item);
        }
        public decimal Price => _bouquet.Price + _decoration.Price;
        public override string ToString()
        {
            var result = new StringBuilder(_bouquet.ToString());
            result.AppendLine($"\nDecorated with {_decoration.Name} that costs {_decoration.Price}");
            result.AppendLine($"\nOverall price: {Price}");
            return result.ToString();
        }
    }
}
