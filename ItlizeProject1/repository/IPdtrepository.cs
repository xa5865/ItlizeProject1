using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItlizeProject1.repository
{
    public class IPdtRepository : IPdt
    {
        private ProjectDatabaseANPEntities DBcontext;

        public IPdtRepository(ProjectDatabaseANPEntities objempcontext)
        {
            this.DBcontext = objempcontext;

        }
        public Models.Product GetPdtByID(int pid)
        {
            return DBcontext.Products.Find(pid);
        }
    }
}