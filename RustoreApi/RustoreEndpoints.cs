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
            //Авторизация
            AuthEndpoint = "/public/auth",
            //Данные платежа
            PaymentByPaymentIdEndpoint = "/public/purchases",
            //Данные тестового платежа
            PaymentByPaymentIdEndpointTest = "/public/sandbox/purchase",
            //Данные подписки версии 2 УСТАРЕЛА и больше не подддерживается подробнее - https://www.rustore.ru/help/work-with-rustore-api/api-subscription-payment/api-id-payment-method
            SubscriptionsByPaymentIdV2Endpoint = "/public/glike/subscription",
            //Данные платежа версии 3 
            SubscriptionsByPaymentIdV3Endpoint = "/public/v3/subscription",
            //Данные платежа версии 3 тестовая подписка
            SubscriptionsByPaymentIdV3EndpointTest = "/public/sandbox/v3/subscription",
            //Получение данных подписки
            PaymentBySubscriptionIdEndpoint = "/public/subscriptions",
            //Получение данных тестовой подписки
            PaymentBySubscriptionIdEndpointTest = "/public/sandbox/subscription"
        };
    }
}