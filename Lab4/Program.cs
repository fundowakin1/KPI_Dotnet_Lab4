using Lab4.Builders;
using Lab4.DirectorServices;
using Lab4.MenuDisplay;

var bouquetBuilder = new BouquetBuilder();
var director = new Director(bouquetBuilder);
var menu = new Menu();

var bouquet = menu.ChooseBouquet(director);
Console.WriteLine();
Console.WriteLine(bouquet);
Console.WriteLine("\nPress any key to continue");
Console.ReadKey();
Console.Clear();
var decoratedBouquet = bouquet;
char key;
do
{
    decoratedBouquet = menu.ChooseDecoration(decoratedBouquet);
    Console.WriteLine();
    Console.WriteLine(decoratedBouquet);
    Console.WriteLine("\n\nDo you want to continue decorating? (if yes press 'y')");
    key = Console.ReadKey().KeyChar;
    Console.Clear();
} while (key == 'y');
