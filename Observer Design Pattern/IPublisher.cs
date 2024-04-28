//Creating an IObservable interface that acts as a Subject
public interface IPublisher{
    public void AddSubscriber(ISubscriber subscriber);
    public void RemoveSubscriber(ISubscriber subscriber);
    public void NotifySubscriber();
}