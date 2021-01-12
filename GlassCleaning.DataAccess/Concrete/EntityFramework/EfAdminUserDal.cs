using GlassCleaning.Core.DataAccess;
using GlassCleaning.DataAccess.Abstract;
using GlassCleaning.DataAccess.Concrete.EntityFramework.Context;
using GlassCleaning.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.DataAccess.Concrete.EntityFramework
{
    public class EfAdminUserDal : EfEntityRepositoryBase<AdminUser, GlassCleaningContext>, IAdminUserDal
    {
    }
}
