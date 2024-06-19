using Microsoft.EntityFrameworkCore;
using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domains;

namespace PersonnelApp.DAL.Repositories.Concrete;

public class DepartmentRepository:Repository<Department>,IDepartmentRepository
{
    
    public DepartmentRepository(PersonnelContext context):base(context)
    {
        
    }

    public IEnumerable<Department> GetTopDepartments(int count)
    {
        return PersonnelContext.Departments.Take(count);
    }

    public IEnumerable<Department> GetDepartmentsWithPersonnels()
    {
        return PersonnelContext.Departments.Include("Personnels").ToList();
    }

    public PersonnelContext PersonnelContext { get{ return _context as PersonnelContext;} }
    
}