using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.NationalIDNumber)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaritalStatus)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Employee", "HumanResources");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.NationalIDNumber).HasColumnName("NationalIDNumber");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.HireDate).HasColumnName("HireDate");
            this.Property(t => t.SalariedFlag).HasColumnName("SalariedFlag");
            this.Property(t => t.HolidayHours).HasColumnName("HolidayHours");
            this.Property(t => t.SickLeaveHours).HasColumnName("SickLeaveHours");
            this.Property(t => t.CurrentFlag).HasColumnName("CurrentFlag");
            this.Property(t => t.PhotoID).HasColumnName("PhotoID");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Address)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.AddressID);
            this.HasRequired(t => t.Contact)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.ContactID);
            this.HasOptional(t => t.MemberUser)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.UserID);
            this.HasOptional(t => t.Photo)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.PhotoID);

        }
    }
}
