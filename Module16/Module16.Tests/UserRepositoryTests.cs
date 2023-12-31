using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void GetNameUserRepositoryNotBull()
        {
            var list = new List<User>()
            {
                new User(){ Name = "Anton"},
                new User(){ Name = "Ivan"},
                new User(){ Name = "Aleksey"},
            };
            var mockUser = new Mock<IUserRepository>();
            mockUser.Setup(x => x.FindAll()).Returns(list);

            Assert.That(mockUser.Object.FindAll().Any(user => user.Name == "Anton"));
            Assert.That(mockUser.Object.FindAll().Any(user => user.Name == "Ivan"));
            Assert.That(mockUser.Object.FindAll().Any(user => user.Name == "Aleksey"));
        }
    }
}
