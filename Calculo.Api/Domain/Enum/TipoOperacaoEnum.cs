using System.ComponentModel;

namespace Calculo.Api.Domain.Enum
{
    public enum TipoOperacaoEnum
    {
        [Description("+")]
        Soma = 1,
        [Description("-")]
        Subtracao = 2,
        [Description("/")]
        Divisao = 3,
        [Description("*")]
        Multiplicacao = 4
    }
}
