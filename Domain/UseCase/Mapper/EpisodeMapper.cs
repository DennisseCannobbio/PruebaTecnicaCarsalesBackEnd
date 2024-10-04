using BackendAPI.Domain.Models;
using BackendAPI.Infrastructure.Gateway.Model;

namespace BackendAPI.Domain.UseCase.Mapper
{
    public class EpisodeMapper
    {
        public static List<EpisodeResponse> MapToDomain(List<ExternalEpisode> input)
        {
            List<EpisodeResponse> ep = new List<EpisodeResponse>();

            for (int i = 0; i < input.Count; i++)
            {
                ep.Add(new EpisodeResponse()
                {
                   Id = input[i].Id,
                   Name = input[i].Name,
                   AirDate = input[i].AirDate,
                   Episode = input[i].Episode,
                   Characters = input[i].Characters,
                   Url = input[i].Url,
                   Created = input[i].Created,  
                });
            }

            return ep;
        }
    }
}
