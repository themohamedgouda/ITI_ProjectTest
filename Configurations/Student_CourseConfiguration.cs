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
    internal class Student_CourseConfiguration : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {
            builder.ToTable("Students_Courses");
            builder.HasKey(SC => new { SC.Student_ID, SC.Course_ID });
            builder.Property(SC => SC.grade).HasColumnName("Student_Grade");
        }
    }
}
