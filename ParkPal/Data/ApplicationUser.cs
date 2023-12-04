using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace ParkPal.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly? DateOfBirth { get; set; }
        public required string Fname { get; set; }
        public required string Lname { get; set; }
    }
}
