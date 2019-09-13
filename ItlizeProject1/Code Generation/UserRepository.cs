
using ItlizeProject1;
using ItlizeProject1.Models;

public class UserRepository : Repository<User>, IUserRepository
{
    private ProjectDatabaseANPEntities _context;

    public UserRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IUserRepository.cs file
}
