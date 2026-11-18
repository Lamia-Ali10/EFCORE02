using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    internal class EventOrganizers
    {
        [Key]
        public int EventOrganizerId { get; set; }
        [MaxLength(100)]
        public string OrganizerName { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public Status EventStatus { get; set; }
        public OrganizerProfile1 OrganizerProfile { get; set; } = null;
        public ICollection<Events>? Events { get; set; }

    }
}
