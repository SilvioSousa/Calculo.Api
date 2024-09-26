using Calculo.Api.Domain.Entities;
using Calculo.Api.Domain.Enum;

namespace Calculo.Api.Domain
{
    public abstract class ExecutaCalculo
    {
        protected ExecutaCalculo(SolicitacaoCalculo solicitacaoCalculo, TipoOperacaoEnum tipoOperacaoEnum)
        {
            SolicitacaoCalculo = solicitacaoCalculo;
            TipoOperacaoEnum = tipoOperacaoEnum;
        }

        public SolicitacaoCalculo SolicitacaoCalculo { get; set; }
        public TipoOperacaoEnum TipoOperacaoEnum { get; set; }

        public abstract int Calcular(SolicitacaoCalculo solicitacaoCalculo);
    }
}
