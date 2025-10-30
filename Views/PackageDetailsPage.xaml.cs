using LogisticsTracker.ViewModels;

namespace LogisticsTracker.Views;

public partial class PackageDetailsPage : ContentPage
{
    public PackageDetailsPage(PackageDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}