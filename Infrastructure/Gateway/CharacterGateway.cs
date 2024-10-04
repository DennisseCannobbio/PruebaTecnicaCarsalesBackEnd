using BackendAPI.Domain.Interfaces.Gateway;
using BackendAPI.Infrastructure.Gateway.Const;
using BackendAPI.Infrastructure.Gateway.Model;
using DIExample.Domain.Exceptions;
using DIExample.Infrastructure.Gateway;
using System.Net;

namespace BackendAPI.Infrastructure.Gateway
{
    public class CharacterGateway : ICharacterGateway
    {

        private HttpClient _httpClient = new HttpClient();
        public ExternalCharacter GetCharacter(int id)
        {
            try
            {
                string url = $"{Constants.BaseUrl}{Constants.CharacterEndPoint}{id}";

                return CommonGateway<ExternalCharacter>.GetFromGateway(url);
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
