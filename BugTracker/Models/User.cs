using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class User:IdentityUser
    {
        public List<int> ProjectIds { get; set; }
        public virtual List<Project> Projects { get; set; }
    }
}
