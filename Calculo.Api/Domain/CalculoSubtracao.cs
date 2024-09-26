using Calculo.Api.Domain;
using Calculo.Api.Domain.Entities;
using Calculo.Api.Domain.Enum;

namespace Calculo.Api.Service
{
    public class CalculoSubtracao : ExecutaCalculo
    {
        public CalculoSubtracao(SolicitacaoCalculo solicitacaoCalculo, TipoOperacaoEnum tipoOperacaoEnum) : base(solicitacaoCalculo, tipoOperacaoEnum)
        {
        }

        public SolicitacaoCalculo SolicitacaoCalculo { get; set; }
        public TipoOperacaoEnum TipoOperacaoEnum { get; set; }

        public override int Calcular(SolicitacaoCalculo solicitacaoCalculo)
        {
            return solicitacaoCalculo.Num1 - solicitacaoCalculo.Num2;
        }
    }
}