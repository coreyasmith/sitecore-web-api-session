using System.Web.Http.WebHost;
using System.Web.Routing;
using System.Web.SessionState;

namespace WebApiEnableSessionHandler.Handlers
{
  public class ReadOnlySessionHttpControllerHandler : HttpControllerHandler, IReadOnlySessionState
  {
    public ReadOnlySessionHttpControllerHandler(RouteData routeData) 
      : base(routeData)
    {
    }
  }
}
