                
using ItlizeProject1.Models;
              
public class NewuserRepository : Repository<NewUser>, INewuserRepository
{
    private ProjectDatabaseANPEntities _context;

    public NewuserRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the INewuserRepository.cs file
}
