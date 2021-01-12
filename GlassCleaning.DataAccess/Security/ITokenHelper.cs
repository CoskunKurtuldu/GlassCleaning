
using GlassCleaning.Core.Utilities.Security.Jwt;
using GlassCleaning.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.DataAccess.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
