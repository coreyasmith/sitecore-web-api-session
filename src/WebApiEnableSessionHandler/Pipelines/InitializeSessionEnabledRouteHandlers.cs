using System.Linq;
using System.Web.Routing;
using Sitecore.Pipelines;
using WebApiEnableSessionHandler.Handlers;

namespace WebApiEnableSessionHandler.Pipelines
{
  public class InitializeSessionEnabledRouteHandlers
  {
    public void Process(PipelineArgs args)
    {
      var routes = RouteTable.Routes.OfType<Route>().Where(r => r.DataTokens != null);
      foreach (var route in routes)
      {
        if (route.DataTokens[Constants.ReadOnlySessionKey] != null)
        {
          route.RouteHandler = new SessionEnabledHttpControllerRouteHandler();
        }
      }
    }
  }
}
