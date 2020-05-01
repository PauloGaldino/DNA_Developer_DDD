using Domain.Core.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, InterfaceClienteRepository
    {
        //Injeção de dependêndencia
        private readonly SqlContext sqlContext;
        public ClienteRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
