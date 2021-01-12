using GlassCleaning.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Model
{
    public class Expense : IEntity
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public string Comment { get; set; }
        public DateTime ExpenseDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Firm Firm { get; set; }
    }
}
