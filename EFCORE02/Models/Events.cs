using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    internal class Events
    {
        public int EventId { get; set; }
        public string Title { get; set; }  
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int NumberOfAttendees { get; set; }
        public EventOrganizers OrganizerProfile { get; set; }
        public int OrganizerProfileID{get; set; }
    }
}
