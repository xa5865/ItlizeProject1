using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

//ProjectDatabaseANPEntities

namespace ItlizeProject1.repository
{
    interface INewUser
    {
        void InsertNewUser(User Newuser1); 
        User GetUserByID(int userid);
    }
}