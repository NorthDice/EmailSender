﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    interface IMessageService
    {
        void SendMessage(string message);
    }
}
