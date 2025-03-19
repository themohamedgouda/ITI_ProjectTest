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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(C => C.Id);
            builder.Property(C => C.Id).UseIdentityColumn(10, 5);
            builder.Property(C => C.Name).IsRequired(true).HasMaxLength(30);
            builder.Property(C => C.Duration).HasAnnotation("DateType", "Date");
            builder.Property(C => C.Description).IsRequired(false).HasMaxLength(100);
            builder.Property(C => C.Top_ID).HasColumnName("Topic_ID");
        }
    }
}
