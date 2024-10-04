namespace DIExample.Domain.UseCase.Utils
{
    public static class UrlUtil
    {
        public static string GetIdFromUrl(string url)
        {
            var cosa = url.Remove(url.LastIndexOf("/character")).Split('/').Last();

            // Dividir la URL por '/'
            string[] parts = url.Split('/');

            // Obtener el último elemento
            string idSegment = parts[parts.Length - 1]; // "1"
            return idSegment;
        }
    }
}
