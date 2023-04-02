namespace RustoreApi
{
  
    public class PaymentBySubscriptionIdResponse
    {
      public string Code { get; set; }
      public string Timestamp { get; set; }
      public string Message { get; set; }
      public PaymentBySubscriptionIdResponseBody Body { get; set; }
    }
    public class PaymentBySubscriptionIdResponseBody
    {
      public int Code { get; set; }
      public bool Success { get; set; }
      public string Message { get; set; }
      public PaymentBySubscriptionIdResponseBodyBody Body { get; set; }
    }
    
    public class PaymentBySubscriptionIdResponseBodyBody
    {
      public string ServiceName { get; set; }
      public int SubscriptionId { get; set; }
      public string AddParameters { get; set; }
      public string ProductType { get; set; }
      public string ProductName { get; set; }
      public string ProductCode { get; set; }
      public string Recurrent { get; set; }
      public int CountOfDay { get; set; }
      public string Action { get; set; }
      public string PeriodType { get; set; }
      public int PeriodDuration { get; set; }
      public string NextPaymentDate { get; set; }
      public int Price { get; set; }
      public string Currency { get; set; }
      public string ImageUrl { get; set; }
      public string State { get; set; }
      public string CurrentPeriod { get; set; }
      public string DebtPaymentPeriod { get; set; }
      public string Description { get; set; }
      public int TariffId { get; set; }
      public PaymentBySubscriptionIdResponseBodyPeriods[] Periods { get; set; }
    }
    
    public class PaymentBySubscriptionIdResponseBodyPeriods
    {
      public string PeriodName { get; set; }
      public string PeriodType { get; set; }
      public string PeriodDuration { get; set; }
      public string PeriodPrice { get; set; }
      public string NextPeriod { get; set; }
    }
}