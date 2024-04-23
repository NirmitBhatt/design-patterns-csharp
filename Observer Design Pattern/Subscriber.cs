public class Subscriber : ISubscriber
{
    private string subscriberName;
    public Subscriber(string subscriberName)
    {
        this.subscriberName = subscriberName;
    }

    public string SubscriberName
    {
        get { return subscriberName; }
    }

    public void UpdateSubscriber()
    {
        Console.WriteLine($"Hey {SubscriberName}! New newsletter from your Subscription.");
    }
}