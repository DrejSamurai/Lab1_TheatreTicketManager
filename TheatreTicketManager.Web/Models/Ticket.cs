using System.ComponentModel.DataAnnotations;

namespace TheatreTicketManager.Web.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public int Price { get; set; }

        public virtual Guid UserId { get; set; }

        public virtual Guid ConcertId { get; set; }
    }
}
