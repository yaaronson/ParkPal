using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParkPal.Models
{
    public class ListingModel
    {
        public int ListingId { get; set; }
        public int HostId { get; set; }
        public int? CustomerId { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? EndTime { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? Description { get; set; }
        public string? AdditionalNotes { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageContentType { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}