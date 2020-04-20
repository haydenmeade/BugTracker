using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Sprint
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Each sprint will be assigned 1 project.
        /// </summary>
        [Required]
        public virtual Project Project { get; set; }

        public virtual List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
