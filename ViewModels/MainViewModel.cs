using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LogisticsTracker.Models;
using LogisticsTracker.Services;
using LogisticsTracker.Views;

namespace LogisticsTracker.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly ITrackingService _trackingService;

        [ObservableProperty]
        string trackingId;

        public MainViewModel(ITrackingService trackingService)
        {
            _trackingService = trackingService;
            Title = "Rastrear Pacote";
        }

       
        [RelayCommand]
        async Task TrackPackageAsync()
        {
            if (string.IsNullOrWhiteSpace(TrackingId))
            {
                await Shell.Current.DisplayAlert("Erro", "Por favor, insira um código de rastreamento.", "OK");
                return;
            }

            if (IsLoading) return;

            try
            {
                IsLoading = true;

                var package = await _trackingService.GetPackageDetailsAsync(TrackingId);

                if (package == null)
                {
                    await Shell.Current.DisplayAlert("Não Encontrado", "Nenhum pacote encontrado com esse código.", "OK");
                }
                else
                {
                
                    await Shell.Current.GoToAsync(nameof(PackageDetailsPage), true, new Dictionary<string, object>
                    {
                        { "Package", package }
                    });

                    
                    TrackingId = string.Empty;
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "OK");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}