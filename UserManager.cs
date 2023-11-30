using System.Data.Common;
using Moq;

class UserManager : IDatabase
{
    private IDatabase UserDatabase;
    private List<User> userList = new List<User>();

    public UserManager(IDatabase db)
    {
        UserDatabase = db;
    }

    /// <summary>
    /// Adds user to the "Database" 
    /// </summary>
    /// <param name="user">An object of class User</param>
    public void AddUser(User user)
    {
       UserDatabase.AddUser(user);
    }

    /// <summary>
    /// If the provided userId finds a user in the "Database" returns user.
    /// </summary>
    /// <param name="userId">An int of the userID</param>
    /// <returns>Either a User if found or null</returns>
    public User GetUser(int userId)
    {
        return UserDatabase.GetUser(userId);
    }

    public bool RemoveUser(int userId)
    {
       return UserDatabase.RemoveUser(userId);
    }
}