﻿using Core.Utilities.IOC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Core.DepedencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<Stopwatch>();
            services.AddSingleton<ConfigurationManager>();
            services.AddSingleton<Random>();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ILoggerService, SerilogLogger>();
        }
    }
}