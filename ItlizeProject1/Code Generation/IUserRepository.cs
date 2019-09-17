using ItlizeProject1.Models;

public interface IUserRepository : IRepository<User>
{
    //Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
    void InsertNewUser(User user);
}
