using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkPal.Data
{
    public class Space
    {
        [Key]
        public string SpaceId { get; set; }

        [ForeignKey("User")]
        public string HostId { get; set; }

        public string? Country { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }
        public decimal XCoord { get; set; }
        public decimal YCoord { get; set; }

        // Consider using an Enum for Size if you have a fixed set of size categories
        public string? Size { get; set; }

        public ApplicationUser User { get; set; } // Navigation property
    }
}