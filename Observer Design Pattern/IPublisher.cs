public interface IPublisher{
    public void AddSubscriber(ISubscriber subscriber);
    public void RemoveSubscriber(ISubscriber subscriber);
    public void NotifySubscriber();
    public void UploadNewsletter(string NewsletterTitle);
}