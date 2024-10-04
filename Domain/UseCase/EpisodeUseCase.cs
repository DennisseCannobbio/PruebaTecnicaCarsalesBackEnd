using BackendAPI.Domain.Interfaces.Gateway;
using BackendAPI.Domain.Interfaces.UseCase;
using BackendAPI.Domain.Models;
using BackendAPI.Domain.UseCase.Mapper;
using BackendAPI.Infrastructure.Gateway.Model;
using DIExample.Domain.UseCase.Utils;

namespace BackendAPI.Domain.UseCase
{
    public class EpisodeUseCase: IEpisodeUseCase
    {

        private readonly IEpisodeGateway _episodeGateway;
        private readonly ICharacterGateway _characterGateway;

        public EpisodeUseCase(IEpisodeGateway episodeGateway, ICharacterGateway characterGateway)
        {
            _episodeGateway = episodeGateway;
            _characterGateway = characterGateway;
        }

        public List<EpisodeResponse> GetEpisodes()
        {
            List<ExternalEpisode> externalEpisode = _episodeGateway.GetEpisodes();

            List<EpisodeResponse> episodes = EpisodeMapper.MapToDomain(externalEpisode);

            //for (int i = 0; i < episodes.Count; i++)
            //{
            //    for (int x = 0; x < episodes[i].Characters.Count; x++)
            //    {
            //        episodes[i].Characters[x] = NameFormatter.SetName(episodes[i], episodes[i].Characters[x], _characterGateway);
            //    }
            //}

            return episodes;
        }
    }
}
