using PersonnelApp.Domains;

namespace PersonnelApp.DAL.Repositories.Abstract;

public interface IPersonnelRepository:IRepository<Personnel>
{
   IEnumerable<Personnel> GetPersonnelsWithDepartments();
}