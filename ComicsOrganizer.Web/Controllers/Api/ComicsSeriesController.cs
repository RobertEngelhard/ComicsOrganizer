using ComicsOrganizer.Web.Models;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ComicsOrganizer.Web.Controllers.Api
{
    [ApiController]
    [Route("[controller]/")]
    public class ComicsSeriesController : ControllerBase
    {
        private readonly ComicsOrganizerDbContext _context;
        public ComicsSeriesController(ComicsOrganizerDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewComicsSeries(ComicsSeriesDto dto)
        {
            //var comics = _context.ComicsSeries.FirstOrDefault();
            await _context.ComicsSeries.AddAsync(new ComicsSeries() { Name = dto.Name });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
