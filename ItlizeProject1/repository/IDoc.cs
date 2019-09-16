using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.repository
{
    interface IDoc
    {
        Document GetDocuByID(int pid);
    }
}