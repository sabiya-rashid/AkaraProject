﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
                builder.HasKey(r => r.Id);
                builder.Property(r => r.Id).ValueGeneratedOnAdd();
                builder.Property(r => r.Name).HasMaxLength(50);
                builder.Property(r => r.Email).HasMaxLength(50);
                builder.Property(r => r.Phone).HasMaxLength(10);

            builder.HasMany(r => r.Properties).WithOne(r=> r.User).HasForeignKey(r => r.UserId);
            //builder.HasMany(r => r.Contracts).WithOne(r => r.User).HasForeignKey(r => r.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

