namespace LogisticsTracker.Models
{
    public class TrackingEvent
    {
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}