using GlassCleaning.Core.Entities;

namespace GlassCleaning.Entities.Dto
{
    public class UserForRegisterDto : IDto
    {
        public int FirmId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string UserExternalRefCode { get; set; }
        public string RefCode { get; set; }
        public int RefCompletedAppointmentCount { get; set; }
        public string Password { get; set; }
    }
}
