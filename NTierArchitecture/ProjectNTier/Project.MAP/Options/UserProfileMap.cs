using Project.ENTITIES.Models;

namespace Project.MAP.Options;

public class UserProfileMap:BaseMap<AppUserProfile>
{
    public UserProfileMap()
    {
        ToTable("Kullanıcı Profilleri");
        Property(x => x.FirstName).HasColumnName("İsim");
        Property(x => x.LastName).HasColumnName("Soyİsim");
    }
}