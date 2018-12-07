using System.Linq;

namespace FCamaraDominio
{
    public class TransformadorDePalavras: ITransformadorDePalavras
    {
        public int CalcularQuantidadeMovimentacaoDaTransformacao(string primeiraPalavra, string segundaPalavra)
        {
            var qtdeCaracteresIguais = primeiraPalavra.ToUpper().Intersect(segundaPalavra.ToUpper());
            var qtdeCaracteresDiferentes = segundaPalavra.ToUpper().Except(primeiraPalavra.ToUpper());

            if (primeiraPalavra.Length == segundaPalavra.Length)
            {
                return segundaPalavra.Length - qtdeCaracteresIguais.Count();
            }

            if (qtdeCaracteresDiferentes.Any()) 
            {
                return qtdeCaracteresDiferentes.Count() + qtdeCaracteresIguais.Count();
            }

            var movimentacoes = segundaPalavra.Count() - primeiraPalavra.Count();

            return segundaPalavra.Count() < primeiraPalavra.Count() ? movimentacoes * -1 : movimentacoes;
        }
    }
}
