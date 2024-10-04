using BackendAPI.Domain.Models;

namespace BackendAPI.Domain.Interfaces.UseCase
{
    public interface ICharacterUseCase
    {
        CharacterResponse GetCharacter(int id);
    }
}
