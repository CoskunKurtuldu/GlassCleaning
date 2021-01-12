using GlassCleaning.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Dto
{
    public class AdminUserLoginDto: IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
