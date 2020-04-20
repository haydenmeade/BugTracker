using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ProjectAccess
    {
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
