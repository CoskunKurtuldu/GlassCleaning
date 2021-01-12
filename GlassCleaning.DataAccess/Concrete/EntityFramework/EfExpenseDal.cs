using GlassCleaning.Core.DataAccess;
using GlassCleaning.DataAccess.Abstract;
using GlassCleaning.DataAccess.Concrete.EntityFramework.Context;
using GlassCleaning.Entities.Model;

namespace GlassCleaning.DataAccess.Concrete.EntityFramework
{
    public class EfExpenseDal : EfEntityRepositoryBase<Expense, GlassCleaningContext>, IExpenseDal
    {
    }
}
