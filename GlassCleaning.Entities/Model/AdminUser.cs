
using GlassCleaning.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Model
{
    public class AdminUser: IEntity
    {
        public int Id { get; set; }
        public int FirmUserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Firm Firm { get; set; }

    }
}
