using Project.ENTITIES.Enums;

namespace Project.ENTITIES.Models;

public abstract class BaseEntity
{
    public int ID { get; set; }
    public DateTime CreatedDate { get; set;  }
    public DateTime? ModifiedDate { get; set;  }
    public  DateTime? DeletedDate { get; set; }
    public DataStatus Status { get; set; }

    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
        Status = DataStatus.Inserted; 
    }
    
}