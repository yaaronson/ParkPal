using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkPal.Data
{
    // This model defines our Spaces table of the database.
    public class Spaces
    {
        [Key]
        public string space_id{ get; set; }

        [ForeignKey("ApplicationUser")]
        public string host_id { get; set; }

        public string? country { get; set; }
        public string? province { get; set; }
        public string? postal_code { get; set; }
        public decimal x_coord { get; set; }
        public decimal y_coord { get; set; }
        // TODO: Potentially limit size to a set data-type (an Enum perhaps?)
        public string?  size { get; set; }
    }
}
