namespace VideoGame.Data.Services
{
    public interface IVideoGameService
    {
        //Task<List<VideoGame>> GetAllVideoGamesAsync();
        //Task<VideoGame> GetVideoGameByIdAsync(int id);
        //Task AddVideoGameAsync(VideoGame videoGame);
        //Task UpdateVideoGameAsync(VideoGame videoGame);
        //Task DeleteVideoGameAsync(int id);

        Task<IEnumerable<VideoGame>> GetAll();
        Task Add(VideoGame videoGame);
        Task Remove(VideoGame videoGame);
        Task<VideoGame> GetById(int id);
        Task Update(VideoGame videoGame);
        Task Update(int id);
    }
}
