namespace CSharpIntermediate.InheritanceSecondPillarOfOOP
{
    public class GoldCustomer:Client
    {
        public void OfferVouchar()
        {
            this.Promote();

            //protected accessibility
           
            //this.CalculateRating(excludeOrders: true);
        }
    }
}