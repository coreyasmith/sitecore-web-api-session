# Web API Session-Enabled Routes

This project contains a Sitecore pipeline processor and extensions to the `HttpRouteCollection`
to enable session in Web API 2.

## Usage

1. Add Sitecore's NuGet repository added to Visual Studio.
2. Build the solution and add `WebApiEnableSessionHandler.dll` as a reference to your Web API 2
projects.
3. Deploy `WebApiEnableSessionHandler.config` into `App_Config\Include\zzz.WebApiEnableSessionHandler`. 
Ensure that `WebApiEnableSessionHandler.Pipelines.InitializeSessionEnabledRouteHandlers` is one of the
last processors in the `initialize` pipeline.
4. Use `config.Routes.AddHttpSessionRoute()` in your Web API initialization to register
session-enabled routes. Set `readOnlySession` to `false` for routes that only need read
access to session; set it to `true` for routes that need read and write access to session.
