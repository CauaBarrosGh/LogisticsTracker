using LogisticsTracker.Models;

namespace LogisticsTracker.Services
{
    public interface ITrackingService
    {
        Task<PackageInfo> GetPackageDetailsAsync(string trackingId);
    }
}