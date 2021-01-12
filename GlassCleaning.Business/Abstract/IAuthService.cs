using GlassCleaning.Core.Utilities.Results;
using GlassCleaning.Core.Utilities.Security.Jwt;
using GlassCleaning.Entities.Dto;
using GlassCleaning.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Business.Abstract
{
    public interface IAuthService
    {

        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
