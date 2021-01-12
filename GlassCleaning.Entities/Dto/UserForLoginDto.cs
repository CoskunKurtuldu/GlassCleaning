

using GlassCleaning.Core.Entities;

namespace GlassCleaning.Entities.Dto
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
