using System.Web.Http.WebHost;
using System.Web.Routing;
using System.Web.SessionState;

namespace WebApiEnableSessionHandler.Handlers
{
  public class SessionRequiredHttpControllerHandler : HttpControllerHandler, IRequiresSessionState
  {
    public SessionRequiredHttpControllerHandler(RouteData routeData) 
      : base(routeData)
    {
    }
  }
}
