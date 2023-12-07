using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Entities;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DriverController : ControllerBase
	{
		private readonly DataContext _context;

        public DriverController(DataContext context)
        {
			_context=context;
		}

        [HttpGet]
		public async Task<ActionResult<List<Driver>>> GetAll()
		{
			var drivers = await _context.Drivers.ToListAsync();
			return Ok(drivers);
		}

		
		[HttpGet("number")]
		public async Task<ActionResult<Driver>> Get(string number)
		{
			var driver = await _context.Drivers.FirstOrDefaultAsync(x=>x.Number==number);
			if (driver == null) { return NotFound("not fount"); }
			return Ok(driver);
		}
	}
}
