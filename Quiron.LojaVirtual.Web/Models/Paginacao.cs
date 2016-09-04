using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; }
        public int ProdutosPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        public int TotalPaginas
        {
            get { return (int)Math.Ceiling((decimal)ItensTotal / ProdutosPorPagina); }
        }
    }
}