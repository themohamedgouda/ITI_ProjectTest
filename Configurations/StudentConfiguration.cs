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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(S => S.Id);
            builder.Property(S => S.Id).UseIdentityColumn(1,1);
            builder.Property(S=>S.FName).IsRequired(true).HasMaxLength(30);
            builder.Property(S=>S.LName).HasMaxLength(30);
            builder.Property(S=>S.Address).HasDefaultValue("Cairo").HasMaxLength(100);
            builder.Property(S=>S.Age).HasColumnType("int");
        }
    }
}
