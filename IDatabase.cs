public interface IDatabase
{
    void AddUser(User user);
    bool RemoveUser(int userId);
    User GetUser(int userId);
}