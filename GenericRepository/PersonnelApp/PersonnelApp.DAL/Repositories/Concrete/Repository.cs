using Microsoft.EntityFrameworkCore;
using PersonnelApp.DAL.Repositories.Abstract;

namespace PersonnelApp.DAL.Repositories.Concrete;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected DbContext _context;
    private DbSet<TEntity> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public TEntity GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }

    public void Add(TEntity entity)
    {
        // _context.Departments
        _dbSet.Add(entity);
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        _dbSet.AddRange(entities);
    }

    public void Remove(int id)
    {
        _dbSet.Remove(GetById(id));
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}