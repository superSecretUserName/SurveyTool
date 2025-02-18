using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SurveyTool.Models; // Ensure that ApplicationUser is defined in this namespace

namespace SurveyTool
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Add a DbSet for each model class like so:
    // public DbSet<YourModel> YourModels { get; set; }




  }
}