
using ItlizeProject1;
using ItlizeProject1.Models;

public class DocumentRepository : Repository<Document>, IDocumentRepository
{
    private ProjectDatabaseANPEntities _context;

    public DocumentRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IDocumentRepository.cs file
}
