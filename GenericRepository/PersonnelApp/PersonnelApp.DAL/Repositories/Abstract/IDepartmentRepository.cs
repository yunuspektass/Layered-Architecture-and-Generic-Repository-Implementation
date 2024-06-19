using PersonnelApp.Domains;

namespace PersonnelApp.DAL.Repositories.Abstract;

public interface IDepartmentRepository:IRepository<Department>
{
    IEnumerable<Department> GetTopDepartments(int count);
    IEnumerable<Department> GetDepartmentsWithPersonnels();
}