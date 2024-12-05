using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class MovieGoSmtpClient
    {
        private readonly string _address;
        private readonly string _password;

        public MovieGoSmtpClient(IConfiguration configuration)
        {
            var gmailConfig = configuration.GetSection("GmailConfig").Get<List<GmailConfig>>().FirstOrDefault();
            if (gmailConfig != null)
            {
                _address = gmailConfig.Address;
                _password = gmailConfig.Password;
            }
            else
            {
                throw new ArgumentNullException("Configuration is empty");
            }
        }

    }
}
