using GlassCleaning.Business.Abstract;
using GlassCleaning.Business.Constants;
using GlassCleaning.Core.Utilities.Results;
using GlassCleaning.Core.Utilities.Security.Hashing;
using GlassCleaning.Core.Utilities.Security.Jwt;
using GlassCleaning.DataAccess.Security;
using GlassCleaning.Entities.Dto;
using GlassCleaning.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            if (!HashingHelper.verifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfullLogin);
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                Name = userForRegisterDto.Name,
                Surname = userForRegisterDto.Surname,
                PhoneCountryCode=userForRegisterDto.PhoneCountryCode,
                PhoneNumber=userForRegisterDto.PhoneNumber,
                Location=userForRegisterDto.Location,
                RefCode=userForRegisterDto.RefCode,
                UserExternalRefCode=userForRegisterDto.UserExternalRefCode,
                RefCompletedAppointmentCount=userForRegisterDto.RefCompletedAppointmentCount,
                FirmId=userForRegisterDto.FirmId,
                CreatedDate=DateTime.Now,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegisteredSuccessful);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
