using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE02.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORE02.Configuration
{
    internal class AttendeeConfiguration:IEntityTypeConfiguration<Attendee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Attendee> builder)
        {
            builder.HasOne<Badge>(A => A.AttendeeBadge).WithOne(B => B.BadgeHolder).HasForeignKey<Badge>(B => B.AttId);

        }   
    
    }
}
