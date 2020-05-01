using Domain.Core.Interfaces.Repositories;
using Domain.Core.Services;
using Domain.Entities;

namespace Domain.Service.Services
{
    public class ProdutoService : ServiceBase<Produto>, InterfaceProdutoService
    {
        //injeção de dependência
        private readonly InterfaceProdutoRepository produtoRepository;
        public ProdutoService(InterfaceProdutoRepository produtoRepository) :base(produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
    }
}
