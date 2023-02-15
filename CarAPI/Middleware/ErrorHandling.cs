using CarAPI.Middleware.Exceptions;

namespace CarAPI.Middleware
{
    public class ErrorHandling : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (BadRequestException badRequestException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(badRequestException.Message);
            }
            catch (NotFoundException notFoundException)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsJsonAsync(notFoundException.Message);
            }
            catch (SystemException)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync("Coś poszło nie tak");
            }
        }
    }
}
