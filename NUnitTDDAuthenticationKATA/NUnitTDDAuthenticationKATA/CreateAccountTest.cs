using NUnit.Framework;
using TDDAuthenticationSprint;

namespace TDDAuthentication.Tests
{
    public class CreateAccountTest
    {
        [SetUp]
        public void Setup()
        {
        }

        // Test Case 1 for AC 1 Sprint 1
        [Test]
        public void ShouldReturn_Sucess_Message_When_Valid_User_Credentials()
        {
            User createAccount = new User();
            string result = createAccount.createUser("amish", "XZ56345148");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 2 for AC 2 Sprint 1

        [Test]
        public void ShouldReturnFailure_Message_When_UserName_Is_Non_Alphabets()
        {
            User createAccount = new User();
            string result = createAccount.createUser("amish123", "passwo14");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 3 for AC 3 Sprint 1

        [Test]
        public void ShouldReturn_Failure_Message_When_User_Name_Is_Greater_Than_11()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amishkhatriii", "password14");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 4 for AC 3 Sprint 1

        [Test]
        public void ShouldReturn_Failure_Message_When_UserName_is_Empty()
        {
           User createAccount = new User();
            string result = createAccount.createUser("", "34514");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 5 for AC 3 Sprint 1

        [Test]
        public void ShouldReturn_Success_Message_When_UserName_Is_GreaterThan_1_and_Less_Than_11()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "YU34348514");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 6 for AC 4 Sprint 1

        [Test]
        public void ShouldReturn_Success_Message_When_Password_Contains_Only_Numbers()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "IY63451489");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 7 for AC 4 Sprint 1

        [Test]
        public void ShouldReturn_Success_Message_When_Password_Contains_Only_Alphanumeric()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "Pass34514");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 8 for AC 4 Sprint 1

        [Test]
        public void ShouldReturn_Failure_Message_When_UserName_Is_Null()
        {
           User createAccount = new User();
            string result = createAccount.createUser(null, "Pass34514");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 9 for AC 1 Sprint 3

        [Test]
        public void ShouldReturn_Failure_Message_When_Password_Is_Less_Than_8_Char_Length()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "P34514");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 10 for AC 2 Sprint 3

        [Test]
        public void ShouldReturn_Failure_Message_When_Password_DoesNot_Contain_Alphabets()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "34514789");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 11 for AC 2 Sprint 3

        [Test]
        public void ShouldReturn_Failure_Message_When_Password_DoesNot_Contains_Minimum_2_Alphabets()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "T34514789");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 12 for AC 2 Sprint 3

        [Test]
        public void ShouldReturn_Success_Message_When_Password_Contains_Minimum_2_Alphabets()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "AB345678");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 13 for AC 3 Sprint 3

        [Test]
        public void ShouldReturn_Failure_Message_When_Password_Doesnot_Contain_Minimum_2_Integers()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "ABVtnITIU5");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 14 for AC 3 Sprint 3

        [Test]
        public void ShouldReturn_Success_Message_When_Password_Contains_Minimum_2_Integers()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "ABVtnITIU12");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 15 for AC 3 Sprint 3
        [Test]
        public void Should_Return_Failure_Message_When_Password_Doesnot_Contain_Any_Integers()
        {
           User createAccount = new User();
            string result = createAccount.createUser("amish", "ABVtnITIU");
            Assert.AreEqual("User Creation Failed", result);
        }
    }
}

