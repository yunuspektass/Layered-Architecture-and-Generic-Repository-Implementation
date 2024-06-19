using Project.ENTITIES.Models;

namespace Project.MAP.Options;

public class ProductMap : BaseMap<Product>
{
    public ProductMap()
    {
        ToTable("Ürünler");
        Property(x => x.ProductName).HasColumnName("Ürün İsmi");
        Property(x => x.UnitPrice).HasColumnName("Fiyat").HasColumnType("money");
        
    }
}