using ClientsControl.Domain.Interfaces;
using ClientsControl.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClientsControl.Infraestructure.Repositories
{
   // Repositório Genérico
    internal class Repository<T>(EntitiesContext context) : IRepository<T> where T : class
    {
        protected readonly EntitiesContext _context = context;

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        
        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }
        
        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
