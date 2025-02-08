using System;

namespace EShop.Shared.Configurations.Email;

public class EmailConfig
{
    public string SmtpServer { get; set; }
    public int SmptPort { get; set; }
    public string SmptUser { get; set; }
    public string SmptPassword { get; set; }

}
