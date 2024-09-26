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
        [HttpPost]
        public int Calcular(SolicitacaoCalculo solicitacaoCalculo, TipoOperacaoEnum tipoOperacaoEnum)
        {
            var resultado = CalcularService.Calcular(solicitacaoCalculo, tipoOperacaoEnum);

            return resultado;
        }
    }
}
