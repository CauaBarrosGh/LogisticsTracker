using LogisticsTracker.Models;

namespace LogisticsTracker.Services
{
    public class MockTrackingService : ITrackingService
    {
       
        private readonly Dictionary<string, PackageInfo> _mockDatabase = new Dictionary<string, PackageInfo>
        {
            {
                "BR12345", new PackageInfo
                {
                    PackageId = "BR12345",
                    Status = "Em trânsito",
                    CurrentLocation = "Centro de Distribuição, São Paulo",
                    SentDate = new DateTime(2025, 10, 28),
                    ExpectedDeliveryDate = new DateTime(2025, 11, 02),
                    History = new List<TrackingEvent>
                    {
                        new TrackingEvent { Timestamp = new DateTime(2025, 10, 30, 10, 15, 0), Location = "São Paulo, SP", Description = "Chegou ao centro de distribuição" },
                        new TrackingEvent { Timestamp = new DateTime(2025, 10, 29, 08, 00, 0), Location = "Curitiba, PR", Description = "Em trânsito para São Paulo" },
                        new TrackingEvent { Timestamp = new DateTime(2025, 10, 28, 14, 30, 0), Location = "Porto Alegre, RS", Description = "Pacote postado" }
                    }
                }
            },
            {
                "US98765", new PackageInfo
                {
                    PackageId = "US98765",
                    Status = "Entregue",
                    CurrentLocation = "Endereço do Cliente, Rio de Janeiro",
                    SentDate = new DateTime(2025, 10, 25),
                    ExpectedDeliveryDate = new DateTime(2025, 10, 29),
                    History = new List<TrackingEvent>
                    {
                        new TrackingEvent { Timestamp = new DateTime(2025, 10, 29, 13, 45, 0), Location = "Rio de Janeiro, RJ", Description = "Entregue ao destinatário" },
                        new TrackingEvent { Timestamp = new DateTime(2025, 10, 29, 09, 10, 0), Location = "Rio de Janeiro, RJ", Description = "Saiu para entrega" },
                        new TrackingEvent { Timestamp = new DateTime(2025, 10, 27, 17, 00, 0), Location = "Miami, FL", Description = "Desembaraço aduaneiro finalizado" }
                    }
                }
            }
        };

        public async Task<PackageInfo> GetPackageDetailsAsync(string trackingId)
        {
           
            await Task.Delay(1000);

            if (_mockDatabase.TryGetValue(trackingId.ToUpper(), out var package))
            {
                return package;
            }

            
            return null;
        }
    }
}