using GlassCleaning.Core.DataAccess;
using GlassCleaning.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.DataAccess.Abstract
{
    public interface IExpenseDal : IEntityRepository<Expense>
    {   
    }
}
