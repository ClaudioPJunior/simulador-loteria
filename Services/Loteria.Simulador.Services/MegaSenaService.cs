using Loteria.Simulador.Domain.Entities;
using Loteria.Simulador.Services.Interfaces.Services;
using Loteria.Simulador.Services.Models.Response;

namespace Loteria.Simulador.Services
{
    public class MegaSenaService : IMegaSenaService
    {
        public async Task<MegaSenaResponse> SimularJogoMegaSena()
        {
            var megaSena = new MegaSena();

            megaSena.GerarJogo6Numeros();

            return await Task.FromResult(new MegaSenaResponse
            {
                Jogo = megaSena.Jogo
            });
        }
    }
}
