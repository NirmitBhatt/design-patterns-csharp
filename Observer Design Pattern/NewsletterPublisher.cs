using System.Data;

public class NewsletterPublisher : IPublisher{

    public List<ISubscriber> subscribers = new List<ISubscriber>();
    public void AddSubscriber(ISubscriber subscriber){
        subscribers.Add(subscriber);

    }

    public void RemoveSubscriber(ISubscriber subscriber){
        subscribers.Remove(subscriber);
    }

    public void NotifySubscriber(){
        foreach(ISubscriber subscriber in subscribers){
        subscriber.UpdateSubscriber();
        }
        
    }

    public void UploadNewsletter(string NewsletterTitle)
    {
        Console.WriteLine($"This is the Newsletter Publisher. We have uploaded a new newsletter: {NewsletterTitle}");
        NotifySubscriber();
    }
}