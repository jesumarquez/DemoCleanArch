using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanArch.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
    }
}
