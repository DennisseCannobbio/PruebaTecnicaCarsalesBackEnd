using BackendAPI.Domain.Interfaces.Gateway;
using BackendAPI.Domain.Interfaces.UseCase;
using BackendAPI.Domain.Models;
using BackendAPI.Domain.UseCase.Mapper;
using BackendAPI.Infrastructure.Gateway.Model;
using System.Numerics;

namespace BackendAPI.Domain.UseCase
{
    public class CharacterUseCase: ICharacterUseCase
    {
        private readonly ICharacterGateway _characterGateway;

        public CharacterUseCase(ICharacterGateway characterGateway)
        {
            _characterGateway = characterGateway;
        }

        public CharacterResponse GetCharacter(int id)
        {
            ExternalCharacter characterResponse = _characterGateway.GetCharacter(id);
            CharacterResponse character = CharacterMapper.MapToDomain(characterResponse);
            return character;
        }
    }
}
