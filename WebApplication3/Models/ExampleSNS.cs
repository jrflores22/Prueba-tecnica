namespace WebApplication3.Models
{
    public class ExampleSNS
    {
        public string Type { get; set; }
        public Guid MessageId { get; set; }
        public string TopicArc { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public string SignatureVersion { get; set; }
        public string Signature { get; set; }
        public string SigningCertURL { get; set; }
        public string UnsubscribeURL { get; set; }
        public MessageAttributes MessageAttributes { get; set; }
    }
}