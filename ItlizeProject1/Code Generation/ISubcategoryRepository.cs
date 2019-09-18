using ItlizeProject1.Models;
using System.Collections.Generic;

public interface ISubcategoryRepository : IRepository<SubCategory>
{
    //Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
    IEnumerable<SubCategory> getSubByCatID(int cateID);
}
