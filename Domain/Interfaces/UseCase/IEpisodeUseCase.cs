using BackendAPI.Domain.Models;

namespace BackendAPI.Domain.Interfaces.UseCase
{
    public interface IEpisodeUseCase
    {
        List<EpisodeResponse> GetEpisodes();
    }
}
