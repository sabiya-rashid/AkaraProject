using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.EntityConfiguration
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
                builder.HasKey(r => r.Id);
                builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder.HasOne(r=> r.Property).WithMany(r=>r.Contracts).HasForeignKey(r=>r.Id).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(r => r.User).WithMany(r => r.Contracts).HasForeignKey(r => r.Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

