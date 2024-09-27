using Calculo.Api.Domain;
using Calculo.Api.Domain.Entities;
using Calculo.Api.Domain.Enum;
using Calculo.Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        /// <summary>
        /// Rota para solicitação de cálculo
        /// </summary>
        /// <param name="solicitacaoCalculo"></param>
        /// <param name="tipoOperacaoEnum"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(int), 200)]
        [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
        public int Calcular([FromBody] SolicitacaoCalculo solicitacaoCalculo, TipoOperacaoEnum tipoOperacaoEnum)
        {
            var resultado = CalcularService.Calcular(solicitacaoCalculo, tipoOperacaoEnum);

            return resultado;
        }
    }
}
