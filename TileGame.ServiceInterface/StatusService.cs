using NServiceKit.ServiceInterface;
using TileGame.ServiceModel;

namespace TileGame.ServiceInterface
{
    public class StatusService : Service
    {
        public StatusResponse Any(Status request)
        {
            return new StatusResponse
            {
                Version = typeof (StatusService).Assembly.GetName().Version.ToString()
            };
        }
    }
}