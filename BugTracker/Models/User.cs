using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class User:IdentityUser
    {
        public virtual List<ProjectAccess> ProjectAccesses { get; set; } = new List<ProjectAccess>();
    }
}
