using Carynne.LojaVirtual.Dominio.Entidades;
using Carynne.LojaVirtual.Dominio.Repositório;
using Carynne.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carynne.LojaVirtual.Web.Controllers
{
    public class CarrinhoController : Controller
    {
        private ProdutosRepositorio _repositorio;

        private Carrinho ObterCarrinho()
        {
            Carrinho carrinho = (Carrinho)Session["Carrinho"];
            if (carrinho == null)
            {
                carrinho = new Carrinho();
                Session["Carrinho"] = carrinho;
            }

            return carrinho;
        }

        // GET: Carrinho
        public RedirectToRouteResult Adicionar(int produtoId, string returnUrl)
        {
            _repositorio = new ProdutosRepositorio();

            Produto produto = _repositorio.Produtos.FirstOrDefault(p => p.ProdutoId.Equals(produtoId));

            if(produto != null)
            {
                ObterCarrinho().AdicionarItem(produto, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult Remover(int produtoId, string returnUrl)
        {
            _repositorio = new ProdutosRepositorio();

            Produto produto = _repositorio.Produtos.FirstOrDefault(p => p.ProdutoId.Equals(produtoId));

            if(produto != null)
            {
                ObterCarrinho().RemoverItem(produto);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CarrinhoViewModel
            {
                Carrinho = ObterCarrinho(),
                ReturnUrl = returnUrl
            });
        }
    }
}