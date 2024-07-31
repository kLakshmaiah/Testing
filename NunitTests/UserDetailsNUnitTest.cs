using NUnit.Framework;
using NunitTests.CodeClass;
namespace NunitTests
{
    [TestFixture]
    public class UserDetailsNUnitTest
    {
       private UserDetails? userDetails {  get; set; } 
        [SetUp]
        public void SetUp()
        {
             userDetails= new();
        }
        [Test]
        public void UserDetails_UserName_IsNull_GetException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                userDetails?.Login(string.Empty, string.Empty);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                userDetails?.Login("Laxman", string.Empty);
            });
        }
    }
}
