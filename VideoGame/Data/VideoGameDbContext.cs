using Microsoft.EntityFrameworkCore;

namespace VideoGame.Data
{
    public class VideoGameDbContext : DbContext
    {
        public VideoGameDbContext(DbContextOptions<VideoGameDbContext> options)
            : base(options)
        {
          
        }
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
    }
    
}
