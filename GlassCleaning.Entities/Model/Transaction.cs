using GlassCleaning.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Model
{
    public class Transaction : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FirmId { get; set; }
        public int AppointmentId { get; set; }
        public int RefUserId { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual User RefUser { get; set; }
        public virtual User User{ get; set; }
        public virtual Appointment Appointment { get; set; }
    }

    public class TransactionEntityConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {




            builder.HasOne(m => m.Firm)
                .WithMany(g => g.Transaction)
                .HasForeignKey(s => s.FirmId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(m => m.User)
               .WithMany(g => g.TransactionUser)
               .HasForeignKey(s => s.UserId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            builder.HasOne(m => m.RefUser)
               .WithMany(g => g.TransactionRefUser)
               .HasForeignKey(s => s.RefUserId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            builder.HasOne(m => m.Appointment)
              .WithMany(g => g.Transaction)
              .HasForeignKey(s => s.AppointmentId)
              .OnDelete(DeleteBehavior.Restrict)
              .IsRequired();

        }
    }
}
