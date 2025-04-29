namespace VideoGame
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Platform { get; set; }
        public int ReleaseYear { get; set; }

        public VideoGame(string title, string genre, string platform, int releaseYear)
        {
            Title = title;
            Genre = genre;
            Platform = platform;
            ReleaseYear = releaseYear;
        }
       
    }
}
