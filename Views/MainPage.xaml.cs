using LogisticsTracker.ViewModels;

namespace LogisticsTracker.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        
        BindingContext = viewModel;
    }
}