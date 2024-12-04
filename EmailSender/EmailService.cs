using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class EmailService : IMessageService
    {
        private readonly ILogger _logger;

        public EmailService(ILogger logger)
        {
            _logger = logger;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Message sended!");

            _logger.Log("Message loged!");
        }
    }
}
