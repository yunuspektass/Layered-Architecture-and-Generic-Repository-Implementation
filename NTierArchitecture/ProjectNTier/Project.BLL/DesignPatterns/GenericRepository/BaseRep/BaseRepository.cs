using System.Linq.Expressions;
using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.Context;
using Project.ENTITIES.Models;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRep;

public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    private MyContext _db;

    public BaseRepository()
    {
        _db = DBTool.DbInstance;
    }

    void Save()
    {
        _db.SaveChanges();
    }


    public List<T> GetAll()
    {
        return _db.Set<T>().ToList();
    }

    public List<T> GetActives()
    {
        return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
    }

    public List<T> GetModifieds()
    {
        return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
    }

    public List<T> GetDeleteds()
    {
        return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);
    }

    public void Add(T item)
    {
        _db.Set<T>().Add(item);
        Save();
    }

    public void AddRange(List<T> list)
    {
        _db.Set<T>().AddRange(list);
        Save();
    }

    public void Delete(T item)
    {
        item.Status = ENTITIES.Enums.DataStatus.Deleted;
        item.DeletedDate = DateTime.Now;
        Save();
    }

    public void DeleteRange(List<T> list)
    {
        foreach (T item in list)
        {
            Delete(item);
        }
    }

    public void Update(T item)
    {
        item.Status = ENTITIES.Enums.DataStatus.Updated;
        item.ModifiedDate = DateTime.Now;
        T unchangedEntity = Find(item.ID);
        _db.Entry(unchangedEntity).CurrentValues.SetValues(item);
        Save();
    }

    public void UpdateRange(List<T> list)
    {
        foreach (T item in list )
        {
            Update(item);
        }
    }

    public void Destroy(T item)
    {
        _db.Set<T>().Remove(item);
        Save();
    }

    public void DestroyRange(List<T> list)
    {
        _db.Set<T>().RemoveRange(list);
        Save();
    }

    public List<T> Where(Expression<Func<T, bool>> exp)
    {
        return _db.Set<T>().Where(exp).ToList();
    }

    public bool Any(Expression<Func<T, bool>> exp)
    {
        return _db.Set<T>().Any(exp);
    }

    public T FirstOrDefault(Expression<Func<T, bool>> exp)
    {
        return _db.Set<T>().FirstOrDefault(exp);
    }

    public object Select(Expression<Func<T, object>> exp)
    {
        return _db.Set<T>().Select(exp);
    }

    public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
    {
        return _db.Set<T>().Select(exp);
    }

    public T Find(int id)
    {
        return _db.Set<T>().Find(id);
    }
}