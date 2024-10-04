using BackendAPI.Domain.Models;
using BackendAPI.Infrastructure.Gateway.Model;
using System.Numerics;

namespace BackendAPI.Domain.UseCase.Mapper
{
    public class CharacterMapper
    {
        public static CharacterResponse MapToDomain(ExternalCharacter input)
        {
            return new CharacterResponse()
            {
                Name = input.Name,
                Id = input.Id,  
                Url = input.Url,
            };
        }
    }
}
