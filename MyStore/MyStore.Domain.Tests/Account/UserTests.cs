using MyStore.Domain.Account.Entities;
using NUnit.Framework;

namespace MyStore.Domain.Tests
{
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var verificationCode = "NADA";
            var user = new User("gustavoborges", "123456");
            user.Verify(verificationCode);

            Assert.IsTrue(user.Verified);
        }
    }
}