namespace PersonnelApp.Domains;

public class Personnel:BaseEntity
{
    public int  Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int DepartmentId  { get; set; }
    public Department Department { get; set; }
    
}