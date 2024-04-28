public class WeeklyNewsletter : NewsletterPublisher
{
    public void UploadNewsletter(string NewsletterTitle)
    {
        Console.WriteLine($"New from our Weekly Newsletter: {NewsletterTitle}");
        NotifySubscriber();
    }
}