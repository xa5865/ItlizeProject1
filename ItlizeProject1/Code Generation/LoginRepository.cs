                
using ItlizeProject1.Models;
              
public class LoginRepository : Repository<Login>, ILoginRepository
{
    private ProjectDatabaseANPEntities _context;

    public LoginRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ILoginRepository.cs file
}
