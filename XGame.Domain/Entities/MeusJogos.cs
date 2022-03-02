using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Entities
{
    public class MeuJogo
    {
        public Guid Id { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejo { get; set; }
        public bool troco { get; set; }
        public bool vendo { get; set; }
        public DateTime DataDesejo { get; set; }
    }
}
