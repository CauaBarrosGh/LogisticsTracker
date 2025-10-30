using CommunityToolkit.Mvvm.ComponentModel;
using LogisticsTracker.Models;
using Windows.ApplicationModel;

namespace LogisticsTracker.ViewModels
{
    
    public partial class PackageDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        [ObservableProperty]
        PackageInfo package;

        public PackageDetailsViewModel()
        {
            Title = "Detalhes do Pacote";
        }

        
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            
            if (query.TryGetValue("Package", out var packageObject))
            {
                
                Package = packageObject as PackageInfo;
            }
        }
    }
}