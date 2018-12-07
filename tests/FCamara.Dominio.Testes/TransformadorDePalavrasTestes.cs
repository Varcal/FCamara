using FCamaraDominio;
using Xunit;

namespace FCamara.Dominio.Testes
{
    public class TransformadorDePalavrasTestes
    {
        [Theory(DisplayName = "Deve_calcular_total_de_movimentacoes_para_transformar_palavra")]
        [Trait("Dominio", "TransformadorDePalavras")]
        [InlineData("Cavalo", "PATO", 4)]
        [InlineData("Gato", "Rato", 1)]
        [InlineData("UVA", "MANGA", 4)]
        [InlineData("Novo", "Velho", 5)]
        [InlineData("Jogo", "Nova", 3)]
        [InlineData("Testes", "Teste", 1)]
        [InlineData("Teste", "Testes", 1)]
        [InlineData("Cavalo", "Cachorro", 5)]
        [InlineData("Cachorro", "Cavalo", 5)]
        public void Deve_calcular_quantidade_de_movimentacoes_para_transformar_palavra(string primeiraPalavra, string segundaPalavra, int quantidadeMovimentacoesEsperadas)
        {
            var transformadorDePalavras = new TransformadorDePalavras();

            var quantidadeMovimentacoes = transformadorDePalavras.CalcularQuantidadeMovimentacaoDaTransformacao(primeiraPalavra.ToUpper(), segundaPalavra.ToUpper());

            Assert.Equal(quantidadeMovimentacoesEsperadas, quantidadeMovimentacoes);
        }
    }
}
