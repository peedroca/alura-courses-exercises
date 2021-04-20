using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class LeilaoController : Controller
    {
        private LeilaoDao _dao;
        private CategoriaDao _categoriaDao;

        public LeilaoController()
        {
            _dao = new LeilaoDao();
            _categoriaDao = new CategoriaDao();
        }

        public IActionResult Index()
        {
            var leiloes = _dao.Listar();
            return View(leiloes);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            ViewData["Categorias"] = _categoriaDao.Listar();
            ViewData["Operacao"] = "Inclusão";
            return View("Form");
        }

        [HttpPost]
        public IActionResult Insert(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _dao.Adicionar(model);
                return RedirectToAction("Index");
            }

            ViewData["Categorias"] = _categoriaDao.Listar();
            ViewData["Operacao"] = "Inclusão";
            return View("Form", model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Categorias"] = _categoriaDao.Listar();
            ViewData["Operacao"] = "Edição";

            var leilao = _dao.Obter(id);

            if (leilao == null)
                return NotFound();

            return View("Form", leilao);
        }

        [HttpPost]
        public IActionResult Edit(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _dao.Adicionar(model);
                return RedirectToAction("Index");
            }

            ViewData["Categorias"] = _categoriaDao.Listar();
            ViewData["Operacao"] = "Edição";

            return View("Form", model);
        }

        [HttpPost]
        public IActionResult Inicia(int id)
        {
            var leilao = _dao.Obter(id);

            if (leilao == null)
                return NotFound();

            if (leilao.Situacao != SituacaoLeilao.Rascunho)
                return StatusCode(405);

            leilao.Situacao = SituacaoLeilao.Pregao;
            leilao.Inicio = DateTime.Now;

            _dao.Atualizar(leilao);

            return RedirectToAction("Index");
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
