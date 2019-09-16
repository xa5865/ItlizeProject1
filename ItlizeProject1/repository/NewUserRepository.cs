using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.repository
{
    public class NewUserRepository:INewUser
    {
        private ProjectDatabaseANPEntities DBcontext;

        public NewUserRepository(ProjectDatabaseANPEntities objempcontext)
        {
            this.DBcontext = objempcontext;

        }
        public void InsertNewUser(Models.User user)
        {
            DBcontext.Users.Add(user);
            DBcontext.SaveChanges();
        }

        public Models.User GetUserByID(int userid)
        {
        return DBcontext.Users.Find(userid);
        }
        //public class 
    }
}