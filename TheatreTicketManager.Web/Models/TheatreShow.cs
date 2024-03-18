using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel.DataAnnotations;

namespace TheatreTicketManager.Web.Models
{
    public class TheatreShow
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Place { get; set; }

        public DateTime ShowDate { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Ticket> showTickets { get; set; }
    }
}
