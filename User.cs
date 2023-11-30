public class User
{
    public int UserID { get; private set; }
    public string Username;
    private static int amountOfUsers = 0;


    public User(string username)
    {
        UserID = _createUserId();
        Username = username;
    }



    /// <summary>
    /// Uses a simple add and increase to give each user a unique ID
    /// </summary>
    /// <returns>A int one larger than previously called creating a unique id everytime</returns>
    private int _createUserId()
    {
        return amountOfUsers++;
    }
}