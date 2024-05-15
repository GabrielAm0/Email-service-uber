namespace email_service_uber.Services.Interfaces;

public interface IEmailSenderService
{
	public Task sendEmail(string toEmail, string subject, string message);
}