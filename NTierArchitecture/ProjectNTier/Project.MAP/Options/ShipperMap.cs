using Project.ENTITIES.Models;

namespace Project.MAP.Options;

public class ShipperMap:BaseMap<Shipper>
{
    public ShipperMap()
    {
        ToTable("Kargocular");
        Property(x => x.CompanyName).HasColumnName("Şirket İsmi");
    }
    
}