using Project.ENTITIES.Models;

namespace Project.MAP.Options;

public class AppUserMap:BaseMap<AppUser>
{
    public AppUserMap()
    {
        ToTable("Kullanıcılar");
        Property(x => x.UserName).HasColumnName("Kullanıcı İsmi");
        Property(x => x.Password).HasColumnName("Şifre");
        HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
    }
    
}