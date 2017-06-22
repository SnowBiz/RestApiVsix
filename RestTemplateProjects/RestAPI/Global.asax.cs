//-----------------------------------------------------------------------
// <copyright file="Global.asax.cs">
//  Copyright (c) 2017 All Rights Reserved
// <author>Alan Snow</author>
// </copyright>
//-----------------------------------------------------------------------

namespace RestAPI
{
    using System.Reflection;
    using System.Web;
    using System.Web.Http;
    using Autofac;
    using Autofac.Integration.WebApi;
    using AutoMapper;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// Startup Application Class
    /// </summary>
    public class WebApiApplication : HttpApplication
    {
        /// <summary>
        /// Applications the start.
        /// </summary>
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            var config = GlobalConfiguration.Configuration;

            // Register Auto Mapper Profiles
            Mapper.Initialize(
                cfg => cfg.AddProfiles(new[]
                {
                    "RestAPI",
                }));

            // Enable cammel case for response fields
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterWebApiFilterProvider(config);

            IoC.Register(builder);

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
