using System;
using System.Net.Mail;
using EShop.Services.Abstract;
using EShop.Shared.Configurations.Email;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace EShop.Services.Concrete;

public class EmailManager : IEmailService
{
    private readonly EmailConfig _emailConfig;
    public EmailManager(EmailConfig emailConfig)
    {
        _emailConfig = emailConfig;
    }   
    public async Task<ResponseDto<NoContent>> SendEmailAsync(string emailTo, string subject, string message)
    {
        try
        {
            if (string.IsNullOrEmpty(emailTo))
            {
                return ResponseDto<NoContent>.Fail("Email address is required",StatusCodes.Status500InternalServerError);
            }
            if (string.IsNullOrEmpty(_emailConfig.SmtpServer))
            {
                return ResponseDto<NoContent>.Fail("Email address is required", StatusCodes.Status500InternalServerError);
            }
            if (string.IsNullOrEmpty(_emailConfig.SmptUser))
            {
                return ResponseDto<NoContent>.Fail("Email address is required", StatusCodes.Status500InternalServerError);
            }
            if (string.IsNullOrEmpty(emailTo))
            {
                return ResponseDto<NoContent>.Fail("Alıcı Email Adresi boş olamaz", StatusCodes.Status400BadRequest);
            }
            if (!IsValidEmail(emailTo))
            {
                return ResponseDto<NoContent>.Fail("Geçersiz Email Adresi", StatusCodes.Status400BadRequest);
            }
           
        }
        catch (System.Exception)
        {
            
            throw;
        }
        private bool IsValidEmail(string emailAddress)
        {
            try
            {
                var addr = new MailAddress(emailAddress);
                return addr.Address == emailAddress;
            }
            catch
            {
                return false;
            }

        }
    }
}
