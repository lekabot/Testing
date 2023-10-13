using ClassLibrary1;
using System.Reflection;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private DummyUser user;

        [TestInitialize]
        public void TestInitialize()
        {
            user = new DummyUser();
            user.FirstName = "Bob";
            user.LastName = "Begins";
            user.Email = "Bob@mer.ci.nsu.ru";
            user.Phone = "+76579075468";
            user.PlaceOfResidence = "Россия";
            user.Gender = "Мужчина";
        }

        [TestMethod]
        public void UserInfo_PropertiesNotEmpty()
        {
            Assert.IsFalse(string.IsNullOrEmpty(user.FirstName), "Firs name is empty");
            Assert.IsFalse(string.IsNullOrEmpty(user.LastName), "Last name is empty");
            Assert.IsFalse(string.IsNullOrEmpty(user.Email), "Email is empty");
            Assert.IsFalse(string.IsNullOrEmpty(user.Phone), "Phone is empty");
            Assert.IsFalse(string.IsNullOrEmpty(user.PlaceOfResidence), "Place of residence is empty");
            Assert.IsFalse(string.IsNullOrEmpty(user.Gender), "Gender is empty");
            Assert.IsFalse(user.ShowFormErrors, "Sgow error messege is true");
        }

        //[TestMethod]
        //public void FirstNameIsNotEmpty()
        //{
        //    Assert.AreEqual(expected: null, actual: user.FirstName, message: "The FirstName field should be initialized as null");
        //    Assert.IsTrue(user.ShowFormErrors, "Null first name should trigger validation error");
        //    Assert.AreEqual(expected: "\nFirst Name cannot be empty", actual: user.ErrorMessage, "Empty FirstName should have correct error msg");

        //    Assert.AreEqual(expected: "Bob", actual: user.FirstName, message: "The FirstName must be set to a value to remove error");
        //    Assert.IsFalse(condition: user.ShowFormErrors, message: "A filled in FirstName should not trigger an error");
        //}

        //[TestMethod]
        //public void EmailIsNotEmpty()
        //{
        //    Assert.AreEqual(expected: null, actual: user.Email, message: "The Email field should be initialized as null");
        //    Assert.IsTrue(user.ShowFormErrors, "Null Email should trigger validation error");
        //    Assert.AreEqual(expected: "\nEmail cannot be empty", actual: user.ErrorMessage, "Empty Email should have correct error msg");

        //    Assert.AreEqual(expected: "Bob@", actual: user.Email, message: "The Email must be set to a value to remove error");
        //    Assert.IsFalse(condition: user.ShowFormErrors, message: "An appropriate filled in Email should not trigger an error");
        //    Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Email should remove error message");
        //}
        
        //[TestMethod]
        //public void EmailHasAtSymbol()
        //{
        //    Assert.AreEqual(expected: "Bob", actual: user.Email, message: "The Email field should be initialized as 'Bob'");
        //    Assert.IsTrue(user.ShowFormErrors, "Invalid Email should trigger validation error");
        //    Assert.AreEqual(expected: "\nEmail must contain @ symbol", actual: user.ErrorMessage, "Empty Email should have correct error msg");

        //    user.Email = "Bob@";
        //    user.Save();
        //    Assert.AreEqual(expected: "Bob@", actual: user.Email, message: "The Email must be set to a value to remove error");
        //    Assert.IsFalse(condition: user.ShowFormErrors, message: "A filled in Email should not trigger an error");
        //    Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Email should remove error message");
        //}

        [TestMethod]
        public void FieldsShouldStartWithCapitalLetter()
        {
            Type userType = user.GetType();
            PropertyInfo[] properties = userType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                char firstChar = property.Name[0];
                Assert.IsTrue(char.IsUpper(firstChar), $"Property '{property.Name}' does not start with a capital letter.");
            }
        }

        [TestMethod]
        public void EmailFieldContainAtSymbol()
        {
            Assert.IsTrue(user.Email.Contains("@"), "Email mast contain @");
        }


        [TestMethod]
        public void PhoneField_StartsWith8OrPlus7()
        {
            Assert.IsTrue(user.Phone.StartsWith("8") || user.Phone.StartsWith("+7"));
        }

        [TestMethod]
        public void CheckCountry()
        {
            Assert.IsTrue(user.PlaceOfResidence == "Россия", "The user must be from Russia");
        }

        [TestMethod]        
        public void IsValidGender()
        { 
            Assert.IsTrue(user.Gender == "Мужчина" || user.Gender == "Женщина" || user.Gender == "Другой");
        }
    }

    class DummyUser : IUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowFormErrors { get; set; }
        public string PlaceOfResidence { get; set; }
        public string Gender { get; set; }

        public event EventHandler? SaveAttempted;

        // Imitate button click s
        public void Save() => SaveAttempted?.Invoke(this, EventArgs.Empty);
    }
}