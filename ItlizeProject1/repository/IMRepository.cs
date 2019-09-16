using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.repository
{
    public class IMRepository:IM
    {
        private ProjectDatabaseANPEntities DBcontext;

        public IMRepository(ProjectDatabaseANPEntities objempcontext)
        {
            this.DBcontext = objempcontext;

        }
        public Models.Manufacturer GetManByID(int pid)
        {
            return DBcontext.Manufacturers.Find(pid);
        }
    }
}