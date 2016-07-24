using System.Linq;
using CadnunsDev.AngularECommerce.Domain.Entities;
using CadnunsDev.AngularECommerce.Domain.Interfaces.Repository;

namespace CadnunsDev.AngularECommerce.Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public Produto BuscarPorCodigoDeBarras(int codigoBarras)
        {
            return Buscar(x => x.CodigoBarras == codigoBarras).FirstOrDefault();
        }
    }
}