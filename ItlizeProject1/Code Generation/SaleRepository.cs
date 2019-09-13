
using ItlizeProject1;
using ItlizeProject1.Models;

public class SaleRepository : Repository<Sale>, ISaleRepository
{
    private ProjectDatabaseANPEntities _context;

    public SaleRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ISaleRepository.cs file
}
