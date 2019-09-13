                
using ItlizeProject1.Models;
              
public class TechnicalSpecificationTagRepository : Repository<Technical_Specification_Tag>, ITechnicalSpecificationTagRepository
{
    private ProjectDatabaseANPEntities _context;

    public TechnicalSpecificationTagRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ITechnicalSpecificationTagRepository.cs file
}
