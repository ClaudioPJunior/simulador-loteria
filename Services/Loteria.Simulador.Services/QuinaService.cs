using Loteria.Simulador.Domain.Entities;
using Loteria.Simulador.Services.Interfaces.Services;
using Loteria.Simulador.Services.Models.Response;

namespace Loteria.Simulador.Services
{
    public class QuinaService : IQuinaService
    {
        public async Task<QuinaResponse> SimularJogoQuina()
        {
            var quina = new Quina();

            quina.GerarJogo5Numeros();

            return await Task.FromResult(new QuinaResponse
            {
                Jogo = quina.Jogo
            });
        }
    }
}
