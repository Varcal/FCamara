using System;
using System.Collections.Generic;
using System.Text;

namespace FCamaraDominio
{
    public interface ITransformadorDePalavras
    {
        int CalcularQuantidadeMovimentacaoDaTransformacao(string primeiraPalavra, string segundaPalavra);
    }
}
