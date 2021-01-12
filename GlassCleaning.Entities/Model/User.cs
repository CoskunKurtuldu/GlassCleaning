using GlassCleaning.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Model
{
    public class User : IEntity
    {
        public int Id { get; set; }
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
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<Transaction> TransactionUser { get; set; }
        public virtual ICollection<Transaction> TransactionRefUser { get; set; }
    }
   

}
