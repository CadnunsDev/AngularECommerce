using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CadnunsDev.AngularECommerce.Application.ViewModels;

namespace CadnunsDev.AngularECommerce.Application.Interfaces
{
    public interface IProdutoAppService : IDisposable
    {
        ProdutoViewModel Adicionar(ProdutoViewModel entity);
        ProdutoViewModel ObterPorId(Guid id);
        IEnumerable<ProdutoViewModel> ObterTodos();
        ProdutoViewModel Atualizar(ProdutoViewModel entity);
        void Remover(Guid id);
    }
}