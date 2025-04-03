using PlatformService.Models;

namespace PlatformService.Data;

public interface IPlatformRepo
{
    public IEnumerable<Platform> GetPlatforms();
    public Platform GetPlatformById(int id);
    public bool PlatformExists(int platformId);
    public bool CreatePlatform(Platform platform);
    public bool UpdatePlatform(Platform platform);
    public bool DeletePlatform(Platform platform);
    public bool SaveChanges();
}