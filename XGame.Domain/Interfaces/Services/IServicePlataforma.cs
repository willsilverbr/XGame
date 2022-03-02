using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Plataforma;

namespace XGame.Domain.Interfaces.Services
{
    interface IServicePlataforma
    {
        AdicionarPlataformaRequest AdcionarPlataforma(AdicionarPlataformaRequest request);


    }
}
