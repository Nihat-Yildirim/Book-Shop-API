using Microsoft.Extensions.Hosting;
using Autofac.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.DependencyResolvers.Autofac;

namespace BookShopAPI.Extensions
{
    public static class HostBuilderExtension
    {
        public static void ConfigureAutofacProviderFactory(this IHostBuilder host)
        {
            host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutoFacBusinessModule());
                });
        }
    }
}