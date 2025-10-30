namespace LogisticsTracker.Models
{
    public class PackageInfo
    {
        public string PackageId { get; set; }
        public string Status { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string CurrentLocation { get; set; }
        public List<TrackingEvent> History { get; set; }
    }
}
