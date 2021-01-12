using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Core.Utilities.Ioc
{
    public interface ICoreModules
    {
        void Load(IServiceCollection services);

    }
}
