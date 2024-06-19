using Project.ENTITIES.Models;
using Project.MAP.Options;

namespace Project.MAP;

public class CategoryMap:BaseMap<Category>
{
    public CategoryMap()
    {
        ToTable("Kategoriler");
        Property(x => x.CategoryName).HasColumnName("Kategori ismi");
        Property(x => x.Description).HasColumnName("Açıklama");
    }
    
}