using BackendAPI.Domain.Interfaces.Gateway;
using BackendAPI.Domain.Models;
using BackendAPI.Infrastructure.Gateway.Model;


namespace DIExample.Domain.UseCase.Utils
{
    public static class NameFormatter
    {
        public static string SetName(EpisodeResponse episode, string characterUrl, ICharacterGateway _characterGatewayt)
        {
            _ = int.TryParse(UrlUtil.GetIdFromUrl(characterUrl), out int characterId);
            ExternalCharacter externalCharacter = _characterGatewayt.GetCharacter(characterId);
            
            return externalCharacter.Name;
        }
    }
}
