using LogisticsTracker.Views;

namespace LogisticsTracker;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(PackageDetailsPage), typeof(PackageDetailsPage));
    }
}