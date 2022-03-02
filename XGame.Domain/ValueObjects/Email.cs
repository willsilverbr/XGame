﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resoucers;

namespace XGame.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, Message.X0_INVALIDO.ToFormat("E-mail"));
        }

        public string Endereco { get; private set; }
        
    }
}
