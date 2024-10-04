using BackendAPI.Domain.Interfaces.Gateway;
using BackendAPI.Infrastructure.Gateway.Model;
using DIExample.Domain.Exceptions;
using DIExample.Infrastructure.Gateway;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Net;
using Constants = BackendAPI.Infrastructure.Gateway.Const.Constants;
namespace BackendAPI.Infrastructure.Gateway
{
    public class EpisodeGateway: IEpisodeGateway
    {

        private HttpClient _httpClient = new HttpClient();
        public List<ExternalEpisode> GetEpisodes()
        {
            try
            {
                string url = $"{Constants.BaseUrl}{Constants.EpisodesEndPoint}?page=1";

                return CommonGateway<ExternalEpisode>.GetFromGatewayLst(url);
            }
            catch (HttpRequestException ex) when (ex is { StatusCode: HttpStatusCode.NotFound })
            {
                throw new NotFoundException("Not Found!");
            }
            catch (HttpRequestException ex) when (ex is { StatusCode: HttpStatusCode.NoContent })
            {
                throw new NoDataException("No Data Found!");
            }
            catch (HttpRequestException ex) when (ex is { StatusCode: HttpStatusCode.InternalServerError })
            {
                throw new InternalServerErrorException("Internal Server Error");
            }
        }
    }
}
