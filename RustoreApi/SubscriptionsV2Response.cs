namespace RustoreApi
{
    public class SubscriptionsV2Response
    {
        public string StartTimeMillis { get; set; }
        public string ExpiryTimeMillis { get; set; }
        public bool AutoRenewing { get; set; }
        public string PriceCurrencyCode { get; set; }
        public string PriceAmountMicros { get; set; }
        public string CountryCode { get; set; }
        public int CancelReason { get; set; }
        public int PaymentState { get; set; }
        public string OrderId { get; set; }
        public int AcknowledgementState { get; set; }
        public string Kind { get; set; }
        public int PurchaseType { get; set; }
        public SubscriptionsV2ResponseIntroductoryPriceInfo IntroductoryPriceInfo { get; set; }
    }

    public class SubscriptionsV2ResponseIntroductoryPriceInfo
    {
        public string IntroductoryPriceCurrencyCode { get; set; }
        public string IntroductoryPriceAmountMicros { get; set; }
        public string IntroductoryPricePeriod { get; set; }
        public int IntroductoryPriceCycles { get; set; }
    }
}
