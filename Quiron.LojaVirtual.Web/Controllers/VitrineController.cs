using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int produtosPorPagina = 3;

        public ViewResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = _repositorio.Produtos
                        .OrderBy(p => p.Nome)
                        .Skip((pagina - 1) * produtosPorPagina)
                        .Take(produtosPorPagina),
                Paginacao = new Paginacao
                    {
                        PaginaAtual = pagina,
                        ProdutosPorPagina = produtosPorPagina,
                        ItensTotal = _repositorio.Produtos.Count()
                    }
            };
            return View(model);
        }
    }
}