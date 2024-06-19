using Project.ENTITIES.Models;

namespace Project.MAP.Options;

public class OrderMap:BaseMap<Order>
{
    public OrderMap()
    {
        ToTable("Siparişler");
        Property(x => x.ShippedAddress).HasColumnName("Teslim Adresi");
    }
}