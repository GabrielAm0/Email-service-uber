using email_service_uber.DTO;
using email_service_uber.Exceptions;
using Microsoft.AspNetCore.Mvc;
using email_service_uber.Services.Interfaces;

namespace email_service_uber.Controllers;

[ApiController]
[Route("send-email")]
public class EmailSenderController : ControllerBase
{
	private readonly IEmailSenderService _emailSenderService;

	public EmailSenderController(IEmailSenderService emailSenderService)
	{
		_emailSenderService = emailSenderService;
	}
	
	[HttpPost]
	public async Task<IActionResult> SendEmail(EmailRequest request)
	{
		try
		{
			await _emailSenderService.sendEmail(request.To, request.Subject, request.Message);
			return Ok("Email was sent successfully!");
		}
		catch (EmailServiceException ex)
		{
			return BadRequest($"Erro ao tentar enviar email,\nErro: {ex.Message},\nStackTrace: {ex.StackTrace}");
		}
	}
}