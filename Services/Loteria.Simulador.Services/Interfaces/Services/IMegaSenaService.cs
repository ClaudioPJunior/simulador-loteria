using Loteria.Simulador.Services.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria.Simulador.Services.Interfaces.Services
{
    public interface IMegaSenaService
    {
        Task<MegaSenaResponse> SimularJogoMegaSena();
    }
}
