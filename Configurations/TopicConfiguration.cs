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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topics");
            builder.HasKey(T => T.Id);
            builder.Property(T => T.Id).UseIdentityColumn(1, 1);
            builder.Property(S => S.Name).IsRequired(true).HasMaxLength(30);

        }
    }
}
