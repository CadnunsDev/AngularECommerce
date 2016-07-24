using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CadnunsDev.AngularECommerce.Application.Interfaces;
using CadnunsDev.AngularECommerce.Application.ViewModels;
using CadnunsDev.AngularECommerce.Domain.Entities;
using CadnunsDev.AngularECommerce.Infra.Data.Repository;

namespace CadnunsDev.AngularECommerce.Application
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoAppService()
        {
            _produtoRepository = new ProdutoRepository();
        }
        public ProdutoViewModel Adicionar(ProdutoViewModel entity)
        {
            var produto = Mapper.Map<Produto>(entity);
            produto = _produtoRepository.Adicionar(produto);
            entity = Mapper.Map<ProdutoViewModel>(produto);
            return entity;
        }

        public ProdutoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ProdutoViewModel>(_produtoRepository.ObterPorId(id));
        }

        public IEnumerable<ProdutoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.ObterTodos());
        }

        public ProdutoViewModel Atualizar(ProdutoViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoViewModel> Buscar(Expression<Func<ProdutoViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
