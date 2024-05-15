namespace email_service_uber.Adapters;

public interface IEmailSenderGateway
{
	public Task SendEmailAsync(string toEmail, string subject, string message);
}