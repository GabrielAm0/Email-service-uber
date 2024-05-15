using email_service_uber.Adapters;
using email_service_uber.Services.Interfaces;

namespace email_service_uber.Services.Impl;

public class EmailSenderService : IEmailSenderService
{
	private readonly IEmailSenderGateway _emailSenderGateway; 


	public EmailSenderService(IEmailSenderGateway emailSenderGateway)
	{
		_emailSenderGateway = emailSenderGateway;
	}
	public async Task sendEmail(string toEmail, string subject, string message)
	{
		await _emailSenderGateway.SendEmailAsync(toEmail, subject, message);
	}
}
