//-----------------------------------------------------------------------
// <copyright file="Global.asax.cs">
//  Copyright (c) 2017 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace $safeprojectname$
{
    using System.Web.Http;

    /// <summary>
    /// Web API Configuration
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: $safeprojectname$,
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
