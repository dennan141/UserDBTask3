using Moq;
public class UserTests
{

    // ---------------------   PROPERTIES   ----------------------------- 
    private Mock<IDatabase> mockDb;
    private UserManager userManager;
    //Setup creates a mocked database
    //and then passes the mocked DB to the usermanager

    // ---------------------   SETUP   ---------------------------------
    [SetUp]
    public void Setup()
    {
        mockDb = new Mock<IDatabase>();
        userManager = new UserManager(mockDb.Object);
    }

    // ---------------------   TEARDOWN   --------------------------------
    //Resets the "database" everytime after an test
    [TearDown]
    public void TearDown()
    {
        mockDb.Reset();
    }


    // ---------------------   TESTS   ---------------------------------

    /// <summary>
    /// Finds a known user via known userId. 
    /// Also checks for calling an unknown user returning null. 
    /// </summary>
    [Test]
    public void TestGetUser()
    {

        //ARRANGE
        User testUser = new User("testingUser");
        User unknownUser = new User("fake user");
        //Makes the "database" return the user testUser when passed the UserID
        mockDb.Setup(database => database.GetUser(testUser.UserID)).Returns(testUser);

        //ACT
        var resultOfFakeUser = userManager.GetUser(unknownUser.UserID);
        var expectedUser = userManager.GetUser(testUser.UserID);

        //ASSERT
        Assert.IsNull(resultOfFakeUser);
        Assert.AreEqual(testUser, expectedUser);
        mockDb.Verify(database => database.GetUser(testUser.UserID), Times.Once);
    }



    /// <summary>
    /// Checks if user is removed both from RemoveUser returning true
    /// and from GetUser not finding user after removed and also checks
    /// that not finding a user returns false.
    /// </summary>
    [Test]
    public void TestRemoveUser()
    {

        //ARRANGE
        User testUser = new User("To be removed");
        User userThatIsNotAdded = new User("fakeUser");
        userManager.AddUser(testUser);

        //Expects a call to RemoveUser and returns true. Meaning finding a user
        mockDb.Setup(database => database.RemoveUser(testUser.UserID)).Returns(true);

        //ACT

        var result = userManager.RemoveUser(testUser.UserID);
        var foundUser = userManager.GetUser(testUser.UserID);
        var fakeUserResult = userManager.RemoveUser(userThatIsNotAdded.UserID);

        //ASSERT
        Assert.IsTrue(result);
        //This verifies that the method in the mocked Database was called once. 
        mockDb.Verify(database => database.RemoveUser(testUser.UserID), Times.Once);
        //This checks that the user was not found using "GetUser"
        Assert.IsNull(foundUser);
        //This checks that a known missing user is NOT found.
        Assert.IsFalse(fakeUserResult);

    }



    [Test]
    public void TestAddUser()
    {
        //ARRANGE
        User newUser = new User("Brand new user");
        //ACT
        userManager.AddUser(newUser);
        //ASSERT
        mockDb.Verify(database => database.AddUser(newUser), Times.Once);
    }

}
