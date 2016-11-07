using System;
using System.Web;
using System.Web.Http.WebHost;
using System.Web.Routing;

namespace WebApiEnableSessionHandler.Handlers
{
  public class SessionEnabledHttpControllerRouteHandler : HttpControllerRouteHandler
  {
    protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
    {
      var routeData = requestContext.RouteData;
      if (routeData.DataTokens[Constants.ReadOnlySessionKey] == null)
      {
        throw new InvalidOperationException("This route is not compatible with session.");
      }

      var readOnlySession = (bool)routeData.DataTokens[Constants.ReadOnlySessionKey];
      if (readOnlySession)
      {
        return new ReadOnlySessionHttpControllerHandler(routeData);
      }
      return new SessionRequiredHttpControllerHandler(routeData);
    }
  }
}
