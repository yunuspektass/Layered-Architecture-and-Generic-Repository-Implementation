using Microsoft.EntityFrameworkCore;
using PersonnelApp.Domains;

namespace PersonnelApp.DAL;

public class PersonnelContext:DbContext
{
    public PersonnelContext()
    {
        
    }

    public PersonnelContext(DbContextOptions<PersonnelContext> options):base(options)
    {
        
    }
    
    
    public DbSet<Department> Departments { get; set; }
    public static DbSet<Personnel> Personnels { get; set; }
}