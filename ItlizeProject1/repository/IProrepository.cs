using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.repository
{
    public class IProRepository : IPro
    {
        private ProjectDatabaseANPEntities DBcontext;

        public IProRepository(ProjectDatabaseANPEntities objempcontext)
        {
            this.DBcontext = objempcontext;

        }
        public Models.Property GetProByID(int pid)
        {
            return DBcontext.Properties.Find(pid);
        }
    }
}