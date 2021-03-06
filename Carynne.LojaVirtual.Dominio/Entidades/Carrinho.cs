﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carynne.LojaVirtual.Dominio.Entidades
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itensCarrinho = new List<ItemCarrinho>();
        
        //Adicionar
        public void AdicionarItem(Produto produto, int quantidade)
        {
            ItemCarrinho item = _itensCarrinho.FirstOrDefault(p => p.Produto.ProdutoId.Equals(produto.ProdutoId));

            if(item == null)
            {
                _itensCarrinho.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }
        }
        
        //Remover
        public void RemoverItem(Produto produto)
        {
            _itensCarrinho.RemoveAll(i => i.Produto.ProdutoId.Equals(produto.ProdutoId));
        }

        //Obter valor total
        public decimal ObterValorTotal()
        {
            return _itensCarrinho.Sum(e => e.Produto.Preco * e.Quantidade);
        }

        //Limpar carrinho
        public void LimparCarrinho()
        {
            _itensCarrinho.Clear();
        }

        //Items carrinho
        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get { return _itensCarrinho; }
        }

    }
    public class ItemCarrinho
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
