using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.repository
{
    interface ITec
    {
        Technical_Specification GetTecByID(int pid);

        IEnumerable<Technical_Specification> GetTec();

    }
}