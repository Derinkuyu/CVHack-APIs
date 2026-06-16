using Microsoft.AspNetCore.Identity;

namespace YourApp.DAL.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public UserProfile? Profile { get; set; }
}
