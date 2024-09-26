using Calculo.Api.Domain;
using Calculo.Api.Domain.Entities;
using Calculo.Api.Domain.Enum;

namespace Calculo.Api.Service
{
    public class CalcularService
    {
        public static int Calcular(SolicitacaoCalculo solicitacaoCalculo, TipoOperacaoEnum tipoOperacaoEnum)
        {
            switch (tipoOperacaoEnum)
            {
                case TipoOperacaoEnum.Soma:
                    var soma = new CalculoSoma(solicitacaoCalculo, tipoOperacaoEnum);
                    return soma.Calcular(solicitacaoCalculo);
                case TipoOperacaoEnum.Subtracao:
                    var subtracao = new CalculoSubtracao(solicitacaoCalculo, tipoOperacaoEnum);
                    return subtracao.Calcular(solicitacaoCalculo);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
