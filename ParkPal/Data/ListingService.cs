using System.Reflection;
using System.Threading.Tasks;
using ParkPal.Data;
using ParkPal.Models;


namespace ParkPal.Services
{
    public class ListingService
    {
        private readonly ApplicationDbContext _context;

        public ListingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddListingAsync(ListingModel model)
        {
            var listing = new Listing
            {
                // Map properties from model to Listing entity
                Title = model.Title,
                Price = model.Price,
                StartDate = model.StartDate,
                StartTime = model.StartTime,
                EndDate = model.EndDate,
                EndTime = model.EndTime,
                Description = model.Description,
                AdditionalNotes = model.AdditionalNotes,
                Latitude = model.Latitude,
                Longitude = model.Longitude
            };

            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();
        }
}
