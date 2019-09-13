
using ItlizeProject1;
using ItlizeProject1.Models;

public class ManufacturerRepository : Repository<Manufacturer>, IManufacturerRepository
{
    private ProjectDatabaseANPEntities _context;

    public ManufacturerRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IManufacturerRepository.cs file
}
