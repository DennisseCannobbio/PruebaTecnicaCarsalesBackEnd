namespace DIExample.Domain.Exceptions
{
    public class GatewayException: Exception
    {
        public GatewayException(string? message) : base(message)
        { 
        }

    }
}
