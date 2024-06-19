using Project.ENTITIES.Models;

namespace Project.MAP.Options;

public class OrderDetailMap:BaseMap<OrderDetail>
{
    public OrderDetailMap()
    {
        ToTable("Satislar");
        Ignore(x => x.ID);
        HasKey(x => new
        {
            x.OrderID,
            x.ProductID
        });
    }
    
}