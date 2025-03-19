using ITI_Project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Project.Configurations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.Property(I => I.Name).IsRequired(true).HasMaxLength(30);
            builder.Property(I => I.Address).HasDefaultValue("Cairo").HasMaxLength(100);
            builder.Property(I => I.Dep_Id).HasColumnName("Department_ID");
            builder.Property(I => I.Salary).HasPrecision(18, 2);
            builder.Property(I => I.Bouns).HasPrecision(18, 2);
            builder.Property(I => I.HourRate).HasPrecision(18, 2);
        }
    }
}
