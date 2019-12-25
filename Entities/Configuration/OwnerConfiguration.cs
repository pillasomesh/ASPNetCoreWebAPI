using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasData(new Owner { OwnerId=Guid.NewGuid(),Name="Som",DateOfBirth=Convert.ToDateTime("25/05/1988"),Address="AP"},
                new Owner { OwnerId = Guid.NewGuid(), Name = "Naidu", DateOfBirth = Convert.ToDateTime("19/12/1986"), Address = "TS" }
                );
        }
    }
}
