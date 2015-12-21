using Carynne.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carynne.LojaVirtual.Dominio.Repositório
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext context = new EfDbContext();

        public IEnumerable<Produto> Produtos {
            get {
                return context.Produtos;
            }
        }
    }
}
