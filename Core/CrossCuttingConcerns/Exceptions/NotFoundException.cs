
namespace Core.CrossCuttingConcerns.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base()
        {

        }
        public NotFoundException() : base()
        {

        }
        public NotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }


    }
}
