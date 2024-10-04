using DIExample.Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace DIExample.Infrastructure.Controllers.Middlewares
{
    public class ExceptionHandlerMiddleware: IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {

            switch (exception)
            {
                case NotFoundException:
                    httpContext.Response.ContentType = "application/json";
                    httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    await httpContext.Response.WriteAsJsonAsync(
                        new
                        {
                            Message = "The requested url does not exists",
                            Status = httpContext.Response.StatusCode,
                        }
                     );
                break;
                case NoDataException:
                    httpContext.Response.ContentType = "application/json";
                    httpContext.Response.StatusCode = (int)HttpStatusCode.NoContent;
                    await httpContext.Response.WriteAsJsonAsync(
                        new
                        {
                            Message = "The requested data does not exists on the database",
                            Status = httpContext.Response.StatusCode,

                        }
                     );
                break;
                case InternalServerErrorException:
                    httpContext.Response.ContentType = "application/json";
                    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    await httpContext.Response.WriteAsJsonAsync(
                        new
                        {
                            Message = "An internal error has occured",
                            Status = httpContext.Response.StatusCode,

                        }
                     );
                break;
            }
            return true;
        }
    }
}
