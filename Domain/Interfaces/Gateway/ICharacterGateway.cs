using BackendAPI.Infrastructure.Gateway.Model;

namespace BackendAPI.Domain.Interfaces.Gateway
{
    public interface ICharacterGateway
    {
        ExternalCharacter GetCharacter(int id);
    }
}
