

namespace AbstractFactoryDemo;
class Program
{
    public static void Main(string[] args)
    {
        IContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new AnimalWorld(africa);
        world.RunFoodChain();

        IContinentFactory america = new AmericaFactory();
        AnimalWorld world1 = new AnimalWorld(america);
        world1.RunFoodChain();

        Console.ReadKey();
    }
}