                
using ItlizeProject1.Models;
              
public class UserRepository : Repository<User>, IUserRepository
{
    private ProjectDatabaseANPEntities _context;

    public UserRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }
    public void InsertNewUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
    //Override any generic method for your own custom implemention, add new repository methods to the IUserRepository.cs file
}
