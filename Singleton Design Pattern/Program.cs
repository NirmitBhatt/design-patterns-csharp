namespace Singleton_Design_Pattern;
class Program
{
    static void Main(string[] args)
    {
        bool checkSingletonInstance;
        Console.WriteLine("Demonstrating Singleton Design Pattern:");
        Singleton firstSingletonInstance = Singleton.GetInstance();
        Singleton secondSingletonInstance = Singleton.GetInstance();

        checkSingletonInstance = (firstSingletonInstance == secondSingletonInstance);
        Console.WriteLine(checkSingletonInstance);

    }
}
