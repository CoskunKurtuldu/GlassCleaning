using GlassCleaning.Core.DataAccess;
using GlassCleaning.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        User GetByMail(string email);
        public List<OperationClaim> GetClaims(User user)
        {
            return new List<OperationClaim>
            {
                new OperationClaim()
                {
                    Id=1,
                    Name="admin"
                }
            };
        }
    }
}
