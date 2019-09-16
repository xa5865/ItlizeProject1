using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.repository
{
    public class ITecRepository :  Repository<Technical_Specification>, ITec
    {
        private ProjectDatabaseANPEntities DBcontext;

        public ITecRepository(ProjectDatabaseANPEntities objempcontext) : base(objempcontext)
        {
            this.DBcontext = objempcontext;

        }
        public Models.Technical_Specification GetTecByID(int pid)
        {
            return DBcontext.Technical_Specification.Find(pid);
        }
        public IEnumerable<Models.Technical_Specification> GetTec()

        {
            return DBcontext.Technical_Specification.ToList();

        }
    }
}