using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.DAL.Repositories.Concrete;

namespace PersonnelApp.DAL;

public class UnitOfWork : IUnitOfWork
{
    private PersonnelContext _personnelContext;


    public UnitOfWork(PersonnelContext context)
    {
        _personnelContext = context;
        DepartmentRepository = new DepartmentRepository(_personnelContext);
        PersonnelRepository = new PersonnelRepository(_personnelContext);
    }

    public IDepartmentRepository DepartmentRepository { get; private set; }
    public IPersonnelRepository PersonnelRepository { get; private set; }

    public int Complete()
    {
        return _personnelContext.SaveChanges();
    }

    public void Dispose()
    {
        _personnelContext.Dispose();
    }
}