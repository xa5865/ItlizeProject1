                
using ItlizeProject1.Models;
              
public class DepartmentRepository : Repository<Department>, IDepartmentRepository
{
    private ProjectDatabaseANPEntities _context;

    public DepartmentRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IDepartmentRepository.cs file
}
