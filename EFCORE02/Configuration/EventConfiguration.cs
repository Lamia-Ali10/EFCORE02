using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE02.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORE02.Configuration
{
    internal class EventConfiguration:IEntityTypeConfiguration<Events>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Events> builder)
        {
            builder.HasKey(E => E.EventId);
            builder.Property(E => E.Title).HasMaxLength(100);
            builder.Property(E => E.Description).HasMaxLength(500);
            builder.Property(E => E.StartDate).IsRequired();
            builder.Property(E => E.EndDate).IsRequired();
  
            
        }
    }
}
