using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Web;
using Carynne.LojaVirtual.Web.Models;
using Carynne.LojaVirtual.Web.HtmlHelpers;

namespace Carynne.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestCarynne
    {
        [TestMethod]
        public void TestPaginacaoTagGenerate()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao()
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };

            Func<int, string> paginaUrl = i => "pagina" + i;

            //Act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //Assert
            Assert.AreEqual(

                @"<a class=""btn btn - default"" href=""pagina1"">1</a>                    <a class=""btn btn - default btn- primary selected"" href=""pagina2"">2</a>                    <a class=""btn btn - default"" href=""pagina3"">3</a>", resultado.ToString()
                  );
        }
    }
}
