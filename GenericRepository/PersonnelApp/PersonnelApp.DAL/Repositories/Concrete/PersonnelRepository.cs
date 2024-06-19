using Microsoft.EntityFrameworkCore;
using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domains;

namespace PersonnelApp.DAL.Repositories.Concrete;

public class PersonnelRepository:Repository<Personnel>,IPersonnelRepository
{
    public PersonnelRepository(PersonnelContext context):base(context)
    {
        
    }
    public PersonnelRepository(DbContext context) : base(context)
    {
    }

    public IEnumerable<Personnel> GetPersonnelsWithDepartments()
    {
        return DAL.PersonnelContext.Personnels.Include("Department").ToList(); 
    }

    public PersonnelContext PersonnelContext {
        get { return _context as PersonnelContext; }
    }
}