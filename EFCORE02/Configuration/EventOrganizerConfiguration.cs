using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE02.Models;

namespace EFCORE02.Configuration
{
    internal class EventOrganizerConfiguration : IEntityTypeConfiguration<EventOrganizers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<EventOrganizers> builder)
        {
            builder.ComplexProperty<OrganizerProfile1>(E => E.OrganizerProfile);
        }
    }
}
