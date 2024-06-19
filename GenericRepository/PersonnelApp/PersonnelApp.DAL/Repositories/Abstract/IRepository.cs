namespace PersonnelApp.DAL.Repositories.Abstract;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity GetById(int id);

    IEnumerable<TEntity> GetAll();
 
    void Add(TEntity entity);

    void AddRange(IEnumerable<TEntity> entities);

    void Remove(int id);

    void RemoveRange(IEnumerable<TEntity> entities);
}