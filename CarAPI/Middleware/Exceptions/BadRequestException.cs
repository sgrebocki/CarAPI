namespace CarAPI.Middleware.Exceptions
{
    public class BadRequestException : SystemException
    {
        public BadRequestException(string ex) : base(ex)
        {

        }
    }
}
