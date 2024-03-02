using Loteria.Simulador.Domain.Entities;
using Loteria.Simulador.Services.Interfaces.Services;
using Loteria.Simulador.Services.Models.Response;

namespace Loteria.Simulador.Services
{
    public class LotoFacilService : ILotoFacilService
    {
        public async Task<LotofacilResponse> SimularJogoLotofacil()
        {
            var jogoLotofacil = new Lotofacil();

            jogoLotofacil.GerarJogo15Numeros();

            return await Task.FromResult(new LotofacilResponse
            {
                Jogo = jogoLotofacil.Jogo
            });
        }
    }
}