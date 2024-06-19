using PersonnelApp.DAL.Repositories.Abstract;

namespace PersonnelApp.DAL;

public interface IUnitOfWork : IDisposable
{
    IDepartmentRepository DepartmentRepository { get; }
    IPersonnelRepository PersonnelRepository { get; }

    int Complete(); 
}