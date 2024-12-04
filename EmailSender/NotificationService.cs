using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class NotificationService
    {
        private readonly IMessageService _messageService;

        public NotificationService(IMessageService messageService )
        {
            _messageService = messageService;
        }

        public void Notify()
        {
            _messageService.SendMessage("Ok!");
        }

    }
}
