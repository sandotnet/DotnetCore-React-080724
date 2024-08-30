namespace HandsOnAPIUsingExceptionHandling.CustomExceptions
{
    public class InternalServerErrorException : Exception
    {
        public InternalServerErrorException(string message) : base(message) { }
    }
}
