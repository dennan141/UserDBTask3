using System.Data.Common;
using Moq;

class UserManager : IDatabase
{

    // ------------------ PROPERTIES & CONSTRUCTOR --------------------
    private IDatabase UserDatabase;

    public UserManager(IDatabase db)
    {
        UserDatabase = db;
    }

    // ---------------------- METHODS ---------------------------------

    /// <summary>
    /// Adds user to the "Database" If no other user already exists
    /// This is where GetUser should check
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
    public User? GetUser(int userId)
    {
        return UserDatabase.GetUser(userId);

    }

    /// <summary>
    /// Removes a user from the database
    /// </summary>
    /// <param name="userId">an Int of the unique UserId</param>
    /// <returns>true if a user is found and removed, otherwise false</returns>
    public bool RemoveUser(int userId)
    {
        return UserDatabase.RemoveUser(userId);
    }
}