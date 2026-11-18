using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    internal class Badge
    {
        public int BadgeId { get; set; }

        public DateTime IssueDate { get; set; }

        public Tier BadgeTier { get; set; }

        public Attendee BadgeHolder { get; set; }
        public int AttId { get; set; }
    }
    internal enum Tier
    { 
       Standard,
       VIP

    }
}
