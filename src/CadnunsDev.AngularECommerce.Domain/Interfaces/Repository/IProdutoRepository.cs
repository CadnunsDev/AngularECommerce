using CadnunsDev.AngularECommerce.Domain.Entities;

namespace CadnunsDev.AngularECommerce.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Produto BuscarPorCodigoDeBarras(int codigoBarras);
    }
}