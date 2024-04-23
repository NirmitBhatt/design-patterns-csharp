using System.ComponentModel;

public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();
    private Singleton()
    {
        //To ensure that the class has only a single instance, we make the constructor private
    }

    //A public static method ensures the creation of the object thus providinga global access point
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            //Implementing double-check locking to ensure thread safety
            lock (lockObject)
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
            }
        }
        return instance;
    }
}