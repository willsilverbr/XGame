using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Entities;
using XGame.Domain.Resoucers;

namespace XGame.Domain.ValueObjects
{
   public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoroNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoroNome = ultimoroNome;

            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50, Message.X0_E_OBRIGATORIA_E_DEVE_CONTER_X2_CARACTER.ToFormat("Primeiro nome", "3", "50"));
            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.UltimoroNome, 3, 50, Message.X0_E_OBRIGATORIA_E_DEVE_CONTER_X2_CARACTER.ToFormat("Primeiro nome", "3", "50"));

          }

        public string PrimeiroNome { get; private set; }

        public string UltimoroNome { get; private set; }
    }
}
