namespace email_service_uber.Exceptions;

public class EmailServiceException : Exception
{
	public EmailServiceException(string message) : base(message){}

	public EmailServiceException(string message, Exception cause) : base(message, cause){}
}