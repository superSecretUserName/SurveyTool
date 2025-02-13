using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyTool; // Update with your actual namespace

public class TestController : Controller
{
  private readonly ApplicationDbContext _context;

  public TestController(ApplicationDbContext context)
  {
    _context = context;
  }

  [HttpGet("/test-db-connection")]
  public async Task<IActionResult> TestDbConnection()
  {
    try
    {
      await _context.Database.OpenConnectionAsync();
      await _context.Database.CloseConnectionAsync();
      return Ok("Successfully connected to the database!");
    }
    catch (Exception ex)
    {
      return StatusCode(500, $"Error: {ex.Message}\n{ex.StackTrace}");
    }
  }
}
