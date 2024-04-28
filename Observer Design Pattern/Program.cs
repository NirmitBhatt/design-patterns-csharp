namespace Simple_Implementation;
class Program
{
    static void Main(string[] args)
    {
        Subscriber Peter  = new Subscriber("Peter");
        Subscriber Mark  = new Subscriber("Mark");
        Subscriber Clint  = new Subscriber("Clint");

        PromotionalNewsletter promotionalNewsletter1 = new PromotionalNewsletter();
        WeeklyNewsletter weeklyNewsletter1 = new WeeklyNewsletter();
        
        promotionalNewsletter1.AddSubscriber(Peter);
        weeklyNewsletter1.AddSubscriber(Mark);
        weeklyNewsletter1.AddSubscriber(Clint);

        promotionalNewsletter1.UploadNewsletter("Amazon Prime Benifits");
        /*Output: New Promotional Offer: Amazon Prime Benifits
        Hey Peter! New newsletter from your Subscription.*/
        weeklyNewsletter1.UploadNewsletter("This week in the Tech World!");
        /*Output: New from our Weekly Newsletter: This week in the Tech World!
        Hey Mark! New newsletter from your Subscription.
        Hey Clint! New newsletter from your Subscription.*/

        weeklyNewsletter1.RemoveSubscriber(Clint);

        promotionalNewsletter1.UploadNewsletter("Promo codes for H&M");
        /*Output: New Promotional Offer: Promo codes for H&M
        Hey Peter! New newsletter from your Subscription.*/
        weeklyNewsletter1.UploadNewsletter("New Tech Releases this Week");
        /*Output: New from our Weekly Newsletter: New Tech Releases this Week
        Hey Mark! New newsletter from your Subscription.*/

        promotionalNewsletter1.AddSubscriber(Clint);

        promotionalNewsletter1.UploadNewsletter("Coupon codes for Kitchenware");
        /*Output: New Promotional Offer: Coupon codes for Kitchenware
        Hey Peter! New newsletter from your Subscription.
        Hey Clint! New newsletter from your Subscription.*/
        weeklyNewsletter1.UploadNewsletter("These Stocks performed best!");
        /*Output: New from our Weekly Newsletter: These Stocks performed best!
        Hey Mark! New newsletter from your Subscription.*/
    }
}
