using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItlizeProject1.repository
{
    public class IDocRepository : IDoc
    {
        private ProjectDatabaseANPEntities DBcontext;

        public IDocRepository(ProjectDatabaseANPEntities objempcontext)
        {
            this.DBcontext = objempcontext;

        }
        public Models.Document GetDocuByID(int pid)
        {
            return DBcontext.Documents.Find(pid);
        }
    }
}