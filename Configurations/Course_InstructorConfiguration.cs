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
    internal class Course_InstructorConfiguration : IEntityTypeConfiguration<Course_Instructor>
    {
        public void Configure(EntityTypeBuilder<Course_Instructor> builder)
        {
            builder.ToTable("Courses_Intructors");
            builder.HasKey(CI => new { CI.Instructor_ID, CI.Course_ID });
            builder.Property(CI => CI.Evaluate).HasColumnName("Evaluation");
        }
    }
}
