using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestePaginacao()
        {
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensTotal = 28,
                ProdutosPorPagina = 10
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            MvcHtmlString resultado = html.PageLinks(paginacao,paginaUrl);
            
            Assert.AreEqual(
                 @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                 + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                 + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
                 );
        }
    }
}
