using GlassCleaning.Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GlassCleaning.Core.DependencyResolvers
{
    public class CoreModule : ICoreModules
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            //services.AddSingleton<ICacheManager, MemoryCacheManager>();
            //services.AddSingleton<Stopwatch>();
        }
    }
}