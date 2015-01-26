using NServiceKit.ServiceHost;

namespace TileGame.ServiceModel
{
    [Route("/status")]
    public class Status : IReturn<StatusResponse>
    {
    }
}