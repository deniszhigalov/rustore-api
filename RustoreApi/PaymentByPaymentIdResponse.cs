using Newtonsoft.Json;

namespace RustoreApi
{
    public class PaymentByPaymentIdResponse
    {
      public string code { get; set; }
      public string message { get; set; }
      public string timestamp { get; set; }
      public PaymentByPaymentIdResponseBody body { get; set; }
    }
  
    public class PaymentByPaymentIdResponseBody
    {
      public PaymentByPaymentIdResponseError error { get; set; }
      public string invoice_id { get; set; }
      public string invoice_date { get; set; }
      public string invoice_status { get; set; }
      public PaymentByPaymentIdResponseInvoice invoice { get; set; }
      public string image { get; set; }
      public string application_code { get; set; }
      public string application_name { get; set; }
      public string owner_code { get; set; }
      public string owner_name { get; set; }
      public PaymentByPaymentIdResponsePaymentInfo payment_info { get; set; }
      public PaymentByPaymentIdResponsePaymentMethods payment_methods { get; set; }
    }
    
    public class PaymentByPaymentIdResponseError
    {
      public string user_message { get; set; }
      public string error_description { get; set; }
      public int error_code { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoice
    {
      public PaymentByPaymentIdResponseInvoicePurchaser purchaser { get; set; }
      public PaymentByPaymentIdResponseInvoiceDeliveryInfo delivery_info { get; set; }
      public PaymentByPaymentIdResponseInvoiceParams[] invoice_params { get; set; }
      public PaymentByPaymentIdResponseInvoiceOrder order { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoicePurchaser
    {
      public string email { get; set; }
      public string phone { get; set; }
      public string contact { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoiceDeliveryInfo
    {
      public PaymentByPaymentIdResponseInvoiceDeliveryInfoAddress address { get; set; }
      public string delivery_type { get; set; }
      public string description { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoiceDeliveryInfoAddress
    {
      public string country { get; set; }
      public string city { get; set; }
      public string address { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoiceParams
    {
      public string key { get; set; }
      public string value { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoiceOrder
    {
      public string order_id { get; set; }
      public string order_number { get; set; }
      public string order_date { get; set; }
      public string service_id { get; set; }
      public int amount { get; set; }
      public string currency { get; set; }
      public string purpose { get; set; }
      public string description { get; set; }
      public string language { get; set; }
      public string expiration_date { get; set; }
      public string tax_system { get; set; }
      public string trade_name { get; set; }
      public string visual_name { get; set; }
      public string org_name { get; set; }
      public string org_inn { get; set; }
      public string visual_amount { get; set; }
      public PaymentByPaymentIdResponseInvoiceOrderBundle[] order_bundle { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoiceOrderBundle
    {
      public int position_id { get; set; }
      public string name { get; set; }
      public PaymentByPaymentIdResponseInvoiceOrderBundleItemParams[] item_params { get; set; }
      public PaymentByPaymentIdResponseInvoiceOrderBundleQuantity quantity { get; set; }
      public int item_amount { get; set; }
      public string currency { get; set; }
      public string item_code { get; set; }
      public int item_price { get; set; }
      public string discount_type { get; set; }
      public string discount_value { get; set; }
      public string interest_type { get; set; }
      public string interest_value { get; set; }
      public string tax_type { get; set; }
      public string tax_sum { get; set; }
      public string image { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoiceOrderBundleItemParams
    {
      public string key { get; set; }
      public string value { get; set; }
    }
    
    public class PaymentByPaymentIdResponseInvoiceOrderBundleQuantity
    {
      public string value { get; set; }
      public string measure { get; set; }
    }
    
    public class PaymentByPaymentIdResponsePaymentInfo
    {
      public string payment_date { get; set; }
      public string payment_id { get; set; }
      public PaymentByPaymentIdResponsePaymentInfoPaymentParams payment_params { get; set; }
      public PaymentByPaymentIdResponsePaymentInfoDeviceInfo device_info { get; set; }
      public PaymentByPaymentIdResponsePaymentInfoLoyaltyInfo loyalty_info { get; set; }
      public string card_id { get; set; }
      public string name { get; set; }
      public string paysys_code { get; set; }
      public string masked_pan { get; set; }
      public string expiry_date { get; set; }
      public string cardholder { get; set; }
      public string payment_system { get; set; }
      public string payment_system_image { get; set; }
      public string image { get; set; }
      public string paysys { get; set; }
      public string paysys_image { get; set; }
      public string payment_way { get; set; }
      public string payment_way_code { get; set; }
      public string payment_way_logo { get; set; }
      public PaymentByPaymentIdResponsePaymentInfoBankInfo bank_info { get; set; }
    }
    
    public class PaymentByPaymentIdResponsePaymentInfoPaymentParams
    {
      public string key { get; set; }
      public string value { get; set; }
    }
    
    public class PaymentByPaymentIdResponsePaymentInfoDeviceInfo
    {
      public string device_platform_type { get; set; }
      public string device_platform_version { get; set; }
      public string device_model { get; set; }
      public string device_manufacturer { get; set; }
      public string device_id { get; set; }
      public string surface { get; set; }
      public string surface_version { get; set; }
    }
    
    public class PaymentByPaymentIdResponsePaymentInfoLoyaltyInfo
    {
      public string service_code { get; set; }
      public string service_name { get; set; }
      public int change_rate { get; set; }
      public int payment_bonus { get; set; }
      public int award_bonus { get; set; }
      public string image { get; set; }
    }
    
    public class PaymentByPaymentIdResponsePaymentInfoBankInfo
    {
      public string bank_name { get; set; }
      public string bank_country_code { get; set; }
      public string bank_country_name { get; set; }
      public string bank_image { get; set; }
    }
    
    public class PaymentByPaymentIdResponsePaymentMethods
    {
      public string user_message { get; set; }
      public PaymentByPaymentIdResponsePaymentMethod[] methods { get; set; }
    }
    
    public class PaymentByPaymentIdResponsePaymentMethod
    {
      public string method { get; set; }
      public string action { get; set; }
    }
}