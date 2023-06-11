using JikanDotNet;

namespace AnixProject.Client.Services.AnimeServices
{
    public interface IAnimeService
    {
        Task<Anime?> GetAnimeAsync();
    }
}
