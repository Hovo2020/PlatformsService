using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Data;

public class PlatformRepo : IPlatformRepo
{
    private readonly AppDbContext _context;
    public PlatformRepo(AppDbContext context)
    {
        _context = context;
    }

    public bool SaveChanges()
    {
        return (_context.SaveChanges() >= 0);
    }

    bool IPlatformRepo.CreatePlatform(Platform platform)
    {
        if(platform == null) {
            throw new ArgumentNullException(nameof(platform));
        }
        else
        {
            _context.Platforms.Add(platform);
            
            return true;
        }
    }

    bool IPlatformRepo.DeletePlatform(Platform platform)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Platform> IPlatformRepo.GetPlatforms()
    {
        return  _context.Platforms.ToList();
    }

    Platform IPlatformRepo.GetPlatformById(int id)
    {
        return _context.Platforms.FirstOrDefault(p => p.Id == id)!;
    }

    bool IPlatformRepo.PlatformExists(int platformId)
    {
        throw new NotImplementedException();
    }

    bool IPlatformRepo.UpdatePlatform(Platform platform)
    {
        throw new NotImplementedException();
    }
}