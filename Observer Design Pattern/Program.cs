namespace Simple_Implementation;
class Program
{
    static void Main(string[] args)
    {
        Subscriber Peter  = new Subscriber("Peter");
        Subscriber Mark  = new Subscriber("Mark");
        Subscriber Clint  = new Subscriber("Clint");

        NewsletterPublisher PromotionalNewsletter = new NewsletterPublisher();
        NewsletterPublisher WeeklyNewsletter = new NewsletterPublisher();
        
        PromotionalNewsletter.AddSubscriber(Peter);
        WeeklyNewsletter.AddSubscriber(Mark);
        WeeklyNewsletter.AddSubscriber(Clint);

        PromotionalNewsletter.UploadNewsletter("Amazon Prime Benifits");
        WeeklyNewsletter.UploadNewsletter("This week in the Tech World!");

        WeeklyNewsletter.RemoveSubscriber(Clint);

        PromotionalNewsletter.UploadNewsletter("Promo codes for H&M");
        WeeklyNewsletter.UploadNewsletter("New Tech Releases this Week");

        PromotionalNewsletter.AddSubscriber(Clint);

        PromotionalNewsletter.UploadNewsletter("Coupon codes for Kitchenware");
        WeeklyNewsletter.UploadNewsletter("These Stocks performed best!");




    }
}
