using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.EntityConfiguration
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Name).HasMaxLength(50);
            builder.Property(r => r.Description).HasMaxLength(200);
            builder.Property(r => r.Country).HasMaxLength(50);
            builder.Property(r => r.State).HasMaxLength(50);
        }
    }
}

