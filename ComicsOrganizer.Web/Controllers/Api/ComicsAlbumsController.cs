using ComicsOrganizer.Web.Models;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComicsOrganizer.Web.Controllers.Api
{
    [ApiController]
    [Route("[controller]/")]
    public class ComicsAlbumsController : ControllerBase
    {
        private readonly ComicsOrganizerDbContext _context;
        public ComicsAlbumsController(ComicsOrganizerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllComicsAlbums()
        {
            var allAlbums = new List<ComicsAlbumsDto>();
            var comicsAlbumsEntities= _context.ComicsAlbums.Include(s=>s.Series).ToList();
            foreach (var album in comicsAlbumsEntities)
            {
                var dto = new ComicsAlbumsDto()
                {
                    AlbumNumber = album.Number,
                    SeriesName = album.Series.Name,
                    Name = album.Name,
                    Owned = album.Owned
                };
                allAlbums.Add(dto); 
            }

            return Ok(allAlbums);
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewComicsAlbums(CreateComicsAlbumsRequest dto)
        {
            var series = _context.ComicsSeries.Find(dto.SeriesId);

            var newComicsAlbums = new ComicsAlbums()
            {
                Name = dto.Name,
                Number = dto.AlbumNumber,
                Owned = dto.Owned,
                Series = series
            };
            await _context.ComicsAlbums.AddAsync(newComicsAlbums);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
