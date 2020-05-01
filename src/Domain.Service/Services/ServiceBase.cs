using Domain.Core.Interfaces.Repositories;
using Domain.Core.Services;
using System.Collections.Generic;

namespace Domain.Service.Services
{
    public class ServiceBase<TEntity> : InterfaceServiceBase<TEntity> where TEntity : class
    {
        //injeção de dependencia
        private readonly InterfaceRepositoryBase<TEntity> repository;
        public ServiceBase(InterfaceRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
