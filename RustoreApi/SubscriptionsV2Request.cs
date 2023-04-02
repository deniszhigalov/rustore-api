namespace RustoreApi
{
    public class SubscriptionsV2Request
    {
        public int UserId { get; set; }
        public string PackageName { get; set; }
        public string SubscriptionToken { get; set; }
        public string SubscriptionId { get; set; }
    }
}