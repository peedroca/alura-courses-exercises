using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using Alura.LeilaoOnline.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class LeilaoController : Controller
    {
        private readonly IAdminService _service;

        public LeilaoController(IAdminService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var leiloes = _service.ListarLeilao();
            return View(leiloes);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            ViewData["Categorias"] = _service.ListarCategoria();
            ViewData["Operacao"] = "Inclusão";
            return View("Form");
        }

        [HttpPost]
        public IActionResult Insert(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _service.CriarLeilao(model);
                return RedirectToAction("Index");
            }

            ViewData["Categorias"] = _service.ListarCategoria();
            ViewData["Operacao"] = "Inclusão";
            return View("Form", model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Categorias"] = _service.ListarCategoria();
            ViewData["Operacao"] = "Edição";

            var leilao = _service.ObterLeilao(id);

            if (leilao == null)
                return NotFound();

            return View("Form", leilao);
        }

        [HttpPost]
        public IActionResult Edit(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _service.AlterarLeilao(model);
                return RedirectToAction("Index");
            }

            ViewData["Categorias"] = _service.ListarCategoria();
            ViewData["Operacao"] = "Edição";

            return View("Form", model);
        }

        [HttpPost]
        public IActionResult Inicia(int id)
        {
            try
            {
                _service.IniciarLeilao(id);
                return RedirectToAction("Index");
            }
            catch (InvalidOperationException)
            {
                return StatusCode(405);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult Finaliza(int id)
        {
            var leilao = _dao.Obter(id);

            if (leilao == null)
                return NotFound();

            if (leilao.Situacao != SituacaoLeilao.Pregao)
                return StatusCode(405);

            leilao.Situacao = SituacaoLeilao.Finalizado;
            leilao.Termino = DateTime.Now;

            _dao.Atualizar(leilao);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var leilao = _dao.Obter(id);

            if (leilao == null)
                return NotFound();

            if (leilao.Situacao == SituacaoLeilao.Pregao)
                return StatusCode(405);

            _dao.Deletar(leilao);

            return NoContent();
        }

        [HttpGet]
        public IActionResult Pesquisa(string termo)
        {
            ViewData["termo"] = termo;

            var leiloes = _dao.Listar()
                .Where(l => string.IsNullOrWhiteSpace(termo) ||
                    l.Titulo.ToUpper().Contains(termo.ToUpper()) ||
                    l.Descricao.ToUpper().Contains(termo.ToUpper()) ||
                    l.Categoria.Descricao.ToUpper().Contains(termo.ToUpper())
                );

            return View("Index", leiloes);
        }
    }
}
