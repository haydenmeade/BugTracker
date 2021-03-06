﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public virtual List<ProjectAccess> ProjectAccesses { get; set; } = new List<ProjectAccess>();
        //public List<Ticket> Backlog { get; set; }
        public virtual List<Sprint> Sprints { get; set; } = new List<Sprint>();
    }
}
