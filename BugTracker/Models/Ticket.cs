using IdentityModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        /// <summary>
        /// Each ticket will be assigned 1 project.
        /// </summary>
        [Required]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public virtual Sprint Iteration { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User AssignedTo { get; set; }

        /// <summary>
        /// Ticket content items.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
        public TicketType Type { get; set; }
        public TicketStatus Status { get; set; }
        public TicketPriority Priority { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}