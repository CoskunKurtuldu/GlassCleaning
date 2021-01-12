using Autofac;
using GlassCleaning.Business.Abstract;
using GlassCleaning.Business.Concrete;
using GlassCleaning.DataAccess.Abstract;
using GlassCleaning.DataAccess.Concrete.EntityFramework;
using GlassCleaning.DataAccess.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Business.DependencyResolves.AutoFact
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
