using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    [ApiController]
    [Route("/api/leiloes")]
    public class LeilaoApiController : ControllerBase
    {
        LeilaoDao _dao;

        public LeilaoApiController()
        {
            _dao = new LeilaoDao();
        }

        [HttpGet]
        public IActionResult EndpointGetLeiloes()
        {
            var leiloes = _dao.Listar();
            return Ok(leiloes);
        }

        [HttpGet("{id}")]
        public IActionResult EndpointGetLeilaoById(int id)
        {
            var leilao = _dao.Obter(id);

            if (leilao == null)
                return NotFound();

            return Ok(leilao);
        }

        [HttpPost]
        public IActionResult EndpointPostLeilao(Leilao leilao)
        {
            _dao.Adicionar(leilao);
            return Ok(leilao);
        }

        [HttpPut]
        public IActionResult EndpointPutLeilao(Leilao leilao)
        {
            _dao.Atualizar(leilao);
            return Ok(leilao);
        }

        [HttpDelete("{id}")]
        public IActionResult EndpointDeleteLeilao(int id)
        {
            var leilao = _dao.Obter(id);

            if (leilao == null)
                return NotFound();

            _dao.Deletar(leilao);

            return NoContent();
        }


    }
}
