using NUnit.Framework;
using TDDAuthenticationSprint;

namespace TDDAuthentication.Tests
{
    [TestFixture]
    public class LoginTest
    {
        // Test Case 1 for AC 1 Sprint 2

        private User createAccount;
        private Login loginUser;

        [OneTimeSetUp]
        public void Setup()
        {
            createAccount = new User();
            loginUser = new Login();
        }

        [Test]        
        public void ShouldReturn_SucessMessage_When_Valid_UserCredentials_Are_Passed()
        {
            createAccount.Users.Add("amish3", "34514");

            loginUser.CreateUser(createAccount);

            string result = loginUser.UserLogin("amish", "34514");
            Assert.AreEqual("User Logged In Successfully", result);

        }

        // Test Case 2 for AC 1 Sprint 2
        [Test]
        public void ShouldReturn_FailureMessage_When_InValid_UserName_Is_Supplied()
        {
            createAccount.Users.Add("amish1", "34514");

            loginUser.CreateUser(createAccount);
            
            string result = loginUser.UserLogin("AmishABS", "34514");
            Assert.AreEqual("Login failed.Invalid username", result);

        }

        // Test Case 3 for AC 2 Sprint 2
        [Test]
        public void ShouldReturn_FailureMessage_When_InValid_Is_Password_Supplied()
        {
            createAccount.Users.Add("amish", "34514");

            loginUser.CreateUser(createAccount);

            string result = loginUser.UserLogin("amish", "ABC");
            Assert.AreEqual("Login failed.Invalid password", result);

        }

        // Test Case 4 for AC 2 Sprint 2
        [Test]
        public void ShouldReturn_FailureMessage_When_Supplied_Password_Is_Empty()
        {
            createAccount.Users.Add("amish2", "34514");

            loginUser.CreateUser(createAccount);

            string result = loginUser.UserLogin("amish", "");
            Assert.AreEqual("Login failed.Invalid password", result);

        }

        // Test Case 5 for AC 2 Sprint 2
        [Test]
        public void ShouldReturn_FailureMessage__WithIn_Supplied_Password_Is_NULL()
        {
            User createAccount = new User();
            createAccount.Users.Add("amish", "34514");

            loginUser.CreateUser(createAccount);

            string result = loginUser.UserLogin("amish", null);
            Assert.AreEqual("Login failed.Invalid password", result);

        }

        //Sprint3 AC1
        [Test]
        public void ShouldReturn_Success_When_Supplied_Password_Length_Is_8_Digits()
        {
            //string expectedResult = "Login Success, with password with 8 digits";
            string password = "test1234";

            bool actualResult = createAccount.IsValidPassword(password);

            Assert.IsTrue(actualResult);
        }


        //Sprint3 AC2
        [Test]
        public void ShouldReturn_Failure_When_Supplied_Password_Length_Is_Less_than_8_Digits()
        {
            string password = "test123";

            bool actualResult = createAccount.IsValidPassword(password);

            Assert.IsFalse(actualResult);
        }

        //Sprint3 AC3
        [Test]
        public void ShouldReturn_Failure_When_Supplied_Password_Contains_Less_than_1_Alphabet()
        {
            //string expectedResult = "Login Success, with password with 8 digits";
            string password = "T123456";

            bool actualResult = createAccount.IsValidPassword(password);

            Assert.IsFalse(actualResult);
        }

        //Sprint3 AC4
        [Test]
        public void ShouldReturn_Sucess_When_Supplied_Password_Contains_Minimum_2_Alphabets()
        {
            //string expectedResult = "Login Success, with password with 8 digits";
            string password = "TT123456";

            bool actualResult = createAccount.IsValidPassword(password);

            Assert.IsTrue(actualResult);
        }

        //Sprint3 AC5
        [Test]
        public void ShouldReturn_Failure_When_Supplied_Password_Contains_Less_than_2_Digits()
        {
            string password = "TT1ABCDE@";

            bool actualResult = createAccount.IsValidPassword(password);

            Assert.IsFalse(actualResult);
        }

        //Sprint3 AC6
        [Test]
        public void ShouldReturn_Success_When_Supplied_Password_Contains_Minimum_2_Digits()
        {
            string password = "TT12BCDE";

            bool actualResult = createAccount.IsValidPassword(password);

            Assert.IsTrue(actualResult);
        }

        [OneTimeTearDown]
        public void TeamDown()
        {
            if (createAccount != null) createAccount = null;
        }
    }
}
