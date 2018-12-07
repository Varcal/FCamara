using System.Threading.Tasks;
using FCamara.Api.Models;
using FCamaraDominio;
using Microsoft.AspNetCore.Mvc;

namespace FCamara.Api.Controllers
{
    [Route("v1/[controller]/[action]")]
    [ApiController]
    public class TransformadorPalavraController : ControllerBase
    {
        private readonly ITransformadorDePalavras _transformadorDePalavras;

        public TransformadorPalavraController(ITransformadorDePalavras transformadorDePalavras)
        {
            _transformadorDePalavras = transformadorDePalavras;
        }

     
        [HttpPost]
        public async Task<int> CalcularQuantidadeMovimentacao([FromBody]TransformadorPalavra transformadorPalavra)
        {
            var totalMovimentacoes = _transformadorDePalavras.CalcularQuantidadeMovimentacaoDaTransformacao(transformadorPalavra.PrimeiraPalavra, transformadorPalavra.SegundaPalavra);

            return await Task.FromResult(totalMovimentacoes);
        }
    }

}