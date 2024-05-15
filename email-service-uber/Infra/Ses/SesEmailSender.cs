using Amazon;
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using email_service_uber.Adapters;
using email_service_uber.Exceptions;

namespace email_service_uber.Infra.Ses;

public class SesEmailSender : IEmailSenderGateway
{
	private readonly AWSCredentials _awsCredentials;

	public SesEmailSender(AWSCredentials awsCredentials)
	{
		_awsCredentials = awsCredentials;
	}
	public async Task SendEmailAsync(string to, string subject, string message)
	{
		using var client = new AmazonSimpleEmailServiceClient(_awsCredentials, RegionEndpoint.USEast1);
		
		SendEmailRequest request = new SendEmailRequest
		{
			Source = "mrgconta@gmail.com",
			Destination = new Destination
			{
				ToAddresses = new List<string> { to }
			},
				Message = new Message
			{
			Subject = new Content(subject),
			Body = new Body
				{
					Text = new Content
					{
						Charset = "UTF-8",
						Data = message
					}
				}
			}
		};
		
		try
		{
			await client.SendEmailAsync(request);
		}
		catch (AmazonServiceException e)
		{
			throw new EmailServiceException(e.Message);
		}
	}
}