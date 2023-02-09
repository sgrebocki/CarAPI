namespace CarAPI.Middleware.Exceptions
{
    public class NotFoundException : SystemException
    {
        public NotFoundException(string ex) : base(ex)
        {

        }
    }
}
