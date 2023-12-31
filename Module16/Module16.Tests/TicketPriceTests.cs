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
    public class TicketPriceTests
    {
        [Test]
        public void TikcketPriceMustReturnNotNullableTicket()
        {
            var mocTicketService = new Mock<ITicketService>();
            mocTicketService.Setup(x => x.GetTicketPrice(1)).Returns(500);
            mocTicketService.Setup(x => x.GetTicketPrice(2)).Returns(1600);
            mocTicketService.Setup(x => x.GetTicketPrice(3)).Returns(4000);

            var ticketPriceTest = new TicketPrice(mocTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 4000);
        }
    }
}
