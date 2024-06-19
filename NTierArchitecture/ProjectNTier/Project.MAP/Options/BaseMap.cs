using Project.ENTITIES.Models;

namespace Project.MAP.Options;
using System.Data.Entity.ModelConfiguration;

public abstract class BaseMap<T>:EntityTypeConfiguration<T> where T : BaseEntity
{
    public BaseMap()
    {
        Property(x => x.CreatedDate).HasColumnName("Yaratilma Tarihi:");
        Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
        Property(x => x.ModifiedDate).HasColumnName("Güncellleme Tarihi");
        Property(x => x.Status).HasColumnName("Veri Durumu");
    }
}