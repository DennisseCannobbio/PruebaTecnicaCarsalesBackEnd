namespace DIExample.Domain.Exceptions
{
    public class NoDataException: Exception
    {
        public NoDataException(string? message) : base(message)
        {
        }
    }
}
