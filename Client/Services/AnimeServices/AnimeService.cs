using JikanDotNet;
namespace AnixProject.Client.Services.AnimeServices
{
    public class AnimeService : IAnimeService 
    {

        private readonly IJikan _jikan;
        public AnimeService(IJikan jikan)
        {
            this._jikan = jikan;
        }
        public async Task<Anime?> GetAnimeAsync()
        {
            var cowboy = await _jikan.GetAnimeAsync(6);
            return cowboy.Data;
        }
    }
}
