using Funq;
using NServiceKit.Logging;
using NServiceKit.Logging.Support.Logging;
using NServiceKit.WebHost.Endpoints;
using TileGame.ServiceInterface;

namespace TileGame.Main
{
    public class AppHost : AppHostHttpListenerLongRunningBase
    {
        public AppHost()
            : base("TileGame Zone Server", typeof (StatusService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            LogManager.LogFactory = new ConsoleLogFactory();
        }
    }
}