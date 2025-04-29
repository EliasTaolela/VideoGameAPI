
using Microsoft.EntityFrameworkCore;

namespace VideoGame.Data.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly VideoGameDbContext _context;

        public VideoGameService(VideoGameDbContext context)
        {
            _context = context; 
        }

        public async Task Add(VideoGame NewGame)
        {
            _context.VideoGames.Add(NewGame);
            await _context.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<VideoGame>> GetAll()
        {
            var videoGames = await _context.VideoGames.ToListAsync();
            return videoGames;
        }

        public Task<VideoGame> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(VideoGame videoGame)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);

        }

        public Task Update(VideoGame videoGame)
        {
            throw new NotImplementedException();
        }
    }
}
