namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        /// <summary>
        /// Each ticket will be assigned 1 project.
        /// </summary>
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        /// <summary>
        /// Ticket content items.
        /// </summary>
        public string Title { get; set; }
        public string Description { get; set; }
        public TicketType Type { get; set; }
        public TicketStatus Status { get; set; }

    }
}