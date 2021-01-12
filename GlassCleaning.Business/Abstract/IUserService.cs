using GlassCleaning.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
