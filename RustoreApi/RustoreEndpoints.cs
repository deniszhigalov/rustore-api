namespace RustoreApi
{
    public class EndpointsData
    {
        public string AuthEndpoint { get; set; }
        public string PaymentByPaymentIdEndpoint { get; set; }
        public string PaymentByPaymentIdEndpointTest { get; set; }
        public string SubscriptionsByPaymentIdV2Endpoint { get; set; }
        public string SubscriptionsByPaymentIdV3Endpoint { get; set; }
        public string SubscriptionsByPaymentIdV3EndpointTest { get; set; }
        public string PaymentBySubscriptionIdEndpoint { get; set; }
        public string PaymentBySubscriptionIdEndpointTest { get; set; }
    }

    public class RustoreEndpoints
    {

        public static EndpointsData Endpoints = new EndpointsData()
        {
            //�����������
            AuthEndpoint = "/public/auth",
            //������ �������
            PaymentByPaymentIdEndpoint = "/public/purchases",
            //������ ��������� �������
            PaymentByPaymentIdEndpointTest = "/public/sandbox/purchase",
            //������ �������� ������ 2 �������� � ������ �� ��������������� ��������� - https://www.rustore.ru/help/work-with-rustore-api/api-subscription-payment/api-id-payment-method
            SubscriptionsByPaymentIdV2Endpoint = "/public/glike/subscription",
            //������ ������� ������ 3 
            SubscriptionsByPaymentIdV3Endpoint = "/public/v3/subscription",
            //������ ������� ������ 3 �������� ��������
            SubscriptionsByPaymentIdV3EndpointTest = "/public/sandbox/v3/subscription",
            //��������� ������ ��������
            PaymentBySubscriptionIdEndpoint = "/public/subscriptions",
            //��������� ������ �������� ��������
            PaymentBySubscriptionIdEndpointTest = "/public/sandbox/subscription"
        };
    }
}