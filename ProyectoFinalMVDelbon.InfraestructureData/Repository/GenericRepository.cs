using ProyectoFinalMVDelbon.InfraestructureData.Data;
using ProyectoFinalMVDelbonDomain.Repositories;

namespace ProyectoFinalMVDelbon.InfraestructureData.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            _context.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}

