namespace RustoreApi
{
    
    public class StatusSubscriptionResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public StatusSubscriptionResponseBody Body { get; set; }
        public string Timestamp { get; set; }
    }
    
    public class StatusSubscriptionResponseBody
    {
        public bool is_active { get; set; }
    }
}