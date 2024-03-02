using Loteria.Simulador.Services.Interfaces.Services;
using Loteria.Simulador.Services.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Loteria.Simulador.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SimuladorController : ControllerBase
    {
        private readonly ILotoFacilService _lotofacilService;
        private readonly IMegaSenaService _megaSenaService;
        private readonly IQuinaService _quinaService;
        
        public SimuladorController(ILotoFacilService lotoFacilService, 
            IMegaSenaService megaSenaService,
            IQuinaService quinaService)
        {
            _lotofacilService = lotoFacilService;
            _megaSenaService = megaSenaService;
            _quinaService = quinaService;
        }

        [HttpGet(nameof(GetJogoLotofacil))]
        [SwaggerOperation(Summary = "Obtém um jogo de 15 números da Lotofácil",
            Description = "Esse endpoint retorna de forma randômica um jogo de 15 números da lotofácil")]
        [SwaggerResponse(200, "Jogo retornado com Sucesso!", typeof(LotofacilResponse))]
        public async Task<IActionResult> GetJogoLotofacil()
        {
            try
            {
                var response = await _lotofacilService.SimularJogoLotofacil();
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet(nameof(GetMegaSena))]
        [SwaggerOperation(Summary = "Obtém um jogo de 6 números da Mega Sena",
            Description = "Esse endpoint retorna de forma randômica um jogo de 6 números da Mega Sena")]
        [SwaggerResponse(200, "Jogo retornado com Sucesso!", typeof(LotofacilResponse))]
        public async Task<IActionResult> GetMegaSena()
        {
            try
            {
                var response = await _megaSenaService.SimularJogoMegaSena();
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet(nameof(GetQuina))]
        [SwaggerOperation(Summary = "Obtém um jogo de 5 números da Quina",
            Description = "Esse endpoint retorna de forma randômica um jogo de 5 números da Quina")]
        [SwaggerResponse(200, "Jogo retornado com Sucesso!", typeof(LotofacilResponse))]
        public async Task<IActionResult> GetQuina()
        {
            try
            {
                var response = await _quinaService.SimularJogoQuina();
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
