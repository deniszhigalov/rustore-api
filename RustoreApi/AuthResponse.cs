namespace RustoreApi
{
    public class AuthResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public AuthBodyResponse Body { get; set; }
        public string Timestamp { get; set; }
    }
    
    public class AuthBodyResponse
    {
        public string Jwe { get; set; }
        public string Ttl { get; set; }
    }
}