using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Module16.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public void FindAllMustReturnCorrectValue()
        {
            var book = new List<Book>()
            {
                new Book () { Title = "Война и мир" },
                new Book () { Title = "Человек-невидимка" },
                new Book () { Title = "Анна Каренина" },
            };

            var mockBook = new Mock<IBookRepository>();
            mockBook.Setup(x => x.FindAll()).Returns(book);

            Assert.Contains(mockBook.Object.FindAll(), (x => x.Title == "Война и мир"));
            Assert.Contains(mockBook.Object.FindAll(), (x => x.Title == "Человек-невидимка"));
            Assert.Contains(mockBook.Object.FindAll(), (x => x.Title == "Анна Каренина"));
        }
    }
}
