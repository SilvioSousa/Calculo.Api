using Calculo.Api.Domain.Entities;
using Calculo.Api.Domain.Enum;

namespace Calculo.Api.Domain
{
    public class CalculoSoma : ExecutaCalculo
    {
        public CalculoSoma(SolicitacaoCalculo solicitacaoCalculo, TipoOperacaoEnum tipoOperacaoEnum) : base(solicitacaoCalculo, tipoOperacaoEnum)
        {
        }

        public override int Calcular(SolicitacaoCalculo solicitacaoCalculo)
        {
            return solicitacaoCalculo.Num1 + solicitacaoCalculo.Num2;
        }
    }
}
