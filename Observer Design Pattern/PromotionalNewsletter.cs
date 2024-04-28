public class PromotionalNewsletter : NewsletterPublisher
{
    public void UploadNewsletter(string NewsletterTitle)
    {
        Console.WriteLine($"New Promotional Offer: {NewsletterTitle}");
        NotifySubscriber();
    }
}