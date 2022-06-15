using Lab4.Bouquets;
using Lab4.Decorators;
using Lab4.DirectorServices;

namespace Lab4.MenuDisplay
{
    public class Menu
    {
        public IBouquet ChooseBouquet(Director director)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nChoose a bouquet:");
                Console.WriteLine("\t1. A simple bouquet");
                Console.WriteLine("\t2. A 'spring' bouquet");
                Console.WriteLine("\t3. An expensive bouquet");
                var key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        director.BuildSimpleBouquet();
                        return director.GetBouquet();
                    case '2':
                        director.BuildSpringBouquet();
                        return director.GetBouquet();
                    case '3':
                        director.BuildExpensiveBouquet();
                        return director.GetBouquet();
                    default:
                        Console.WriteLine("\nInvalid input");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public IBouquet ChooseDecoration(IBouquet bouquet)
        {
            while (true)
            {
                Console.WriteLine("\nChoose a decoration:");
                Console.WriteLine("\t1. A stripe");
                Console.WriteLine("\t2. A basket");
                var key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        return new StripeDecorator(bouquet);
                    case '2':
                        return new BasketDecorator(bouquet);
                    default:
                        Console.WriteLine("\nInvalid input");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
    }
}
