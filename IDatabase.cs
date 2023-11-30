public interface IDatabase
{
    bool AddUser(User user);
    bool RemoveUser(int userId);
    User GetUser(int userId);
}