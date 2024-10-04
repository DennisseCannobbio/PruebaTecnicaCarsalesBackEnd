using BackendAPI.Infrastructure.Gateway.Model;

namespace BackendAPI.Domain.Interfaces.Gateway
{
    public interface IEpisodeGateway
    {
        List<ExternalEpisode> GetEpisodes();
    }
}
