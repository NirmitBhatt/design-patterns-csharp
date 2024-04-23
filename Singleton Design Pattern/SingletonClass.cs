using System.ComponentModel;

public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();
    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
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