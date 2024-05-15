using Amazon.Runtime;
using email_service_uber.Adapters;
using email_service_uber.Infra.Ses;
using email_service_uber.Services.Impl;
using email_service_uber.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<AWSCredentials>(new BasicAWSCredentials(builder.Configuration["AWS:AccessKeyID"],builder.Configuration["AWS:SecretAccessKey"]));

builder.Services.AddScoped<IEmailSenderService, EmailSenderService>();
builder.Services.AddScoped<IEmailSenderGateway, SesEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
