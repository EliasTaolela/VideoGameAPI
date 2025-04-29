using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGame.Data;

namespace VideoGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly VideoGameDbContext _context;

        public VideoGameController(VideoGameDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetVideoGames()
        {
            return Ok(await _context.VideoGames.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGameById(int id)
        {
            var videoGame = await _context.VideoGames.FindAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }
            return Ok(videoGame);
        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddVideoGame(VideoGame NewGame)
        {
            _context.VideoGames.Add(NewGame);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVideoGameById), new { id = NewGame.Id }, NewGame);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateVideoGame(int id, VideoGame updatedGame)
        {
           var game = await _context.VideoGames.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            game.Title = updatedGame.Title;
            game.Genre = updatedGame.Genre;
            game.Platform = updatedGame.Platform;
            game.ReleaseYear = updatedGame.ReleaseYear;
            await _context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            _context.VideoGames.Remove(game);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
