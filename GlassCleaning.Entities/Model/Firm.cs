using GlassCleaning.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Model
{
    public class Firm : IEntity
    {
        public int Id { get; set; }
        public string FirmName { get; set; }
        public string EMail { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<AdminUser> AdminUser { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<Expense> Expense { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
