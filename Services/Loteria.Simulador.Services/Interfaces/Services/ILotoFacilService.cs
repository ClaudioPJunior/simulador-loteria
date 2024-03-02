using Loteria.Simulador.Services.Models.Response;

namespace Loteria.Simulador.Services.Interfaces.Services
{
    public interface ILotoFacilService
    {
        Task<LotofacilResponse> SimularJogoLotofacil();
    }
}
