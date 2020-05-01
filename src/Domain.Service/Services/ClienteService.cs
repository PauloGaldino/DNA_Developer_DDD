using Domain.Core.Interfaces.Repositories;
using Domain.Core.Services;
using Domain.Entities;

namespace Domain.Service.Services
{
    public class ClienteService : ServiceBase<Cliente>, InterfaceClienteService
    {
        //injeção de dependência
        private readonly InterfaceClienteRepository clienteRepository;
        public ClienteService(InterfaceClienteRepository clienteRepository) : base(clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
    }
}
