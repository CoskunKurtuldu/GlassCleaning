using GlassCleaning.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Model
{
    public class Appointment :IEntity
    {
        public int Id { get; set; }
        public int AppointmentType { get; set; } // 0- oluşturuldu, 1- iptal edildi (Admin), 2- İptal edildi kullanıcı.
        public int FirmId { get; set; }
        public int UserId { get; set; }
        public short AppointmentDate { get; set; }
        public short AppointmentHour { get; set; }
        public short AppointmentYear { get; set; }
        public short WindowsCount { get; set; }
        public string CancelReason { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CancelDate { get; set; }
        public virtual Firm Firm { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }

    }
}
