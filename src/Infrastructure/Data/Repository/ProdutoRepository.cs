using Domain.Core.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, InterfaceProdutoRepository
    {
        //Injeção de dependência
        private readonly SqlContext sqlContext;
        public ProdutoRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

    }
}
