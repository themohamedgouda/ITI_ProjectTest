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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(D=>D.Id);
            builder.Property(D=>D.Id).UseIdentityColumn(10,10);
            builder.Property(D=>D.Name).IsRequired().HasMaxLength(30);
            builder.Property(D => D.Ins_ID).HasColumnName("Instructor_ID");
            builder.Property(D => D.HiringDate).HasAnnotation("DateType","Date");
            builder.HasOne<Instructor>(I => I.Dept_Manager).WithOne(I => I.Department).HasForeignKey<Department>(D => D.Manager_Id);

        }
    }
}
