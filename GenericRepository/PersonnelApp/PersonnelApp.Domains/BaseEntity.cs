namespace PersonnelApp.Domains;

public class BaseEntity
{
    public DateTime? CreatedDate { get; set; }
    
    public DateTime? UpdateDate { get; set; }
    
    public DateTime? DeleteDate { get; set; }
    
    public bool IsActive { get; set; }
}