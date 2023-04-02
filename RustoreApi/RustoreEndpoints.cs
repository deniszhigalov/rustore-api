namespace RustoreApi
{
    public class EndpointsData
    {
        public string AuthEndpoint { get; set; }
        public string PaymentByPaymentIdEndpoint { get; set; }
        public string SubscriptionsByPaymentIdV2Endpoint { get; set; }
        public string PaymentBySubscriptionIdEndpoint { get; set; }
    }

    public class RustoreEndpoints
    {

        public static EndpointsData Endpoints = new EndpointsData()
        {
            AuthEndpoint = "/public/auth",
            PaymentByPaymentIdEndpoint = "/public/purchases",
            SubscriptionsByPaymentIdV2Endpoint = "/public/v2/subscription",
            PaymentBySubscriptionIdEndpoint = "/public/subscriptions"
        };
    }
}