using Microsoft.EntityFrameworkCore;
using SurveyTool.Models;

namespace SurveyTool
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Add a DbSet for each model class like so:
    // public DbSet<YourModel> YourModels { get; set; }




  }
}