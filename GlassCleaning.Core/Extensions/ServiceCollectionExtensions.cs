using GlassCleaning.Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services,
            ICoreModules[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(services);

            }

            return ServiceTool.Create(services);
        }
    }
}
