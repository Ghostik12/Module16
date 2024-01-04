using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Module16.Tests
{
    public class TicketServiceTests
    {
        [Fact]
        public void GetTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Xunit.Assert.NotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Fact]
        public void GeTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Xunit.Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }
         
        [Fact]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Xunit.Assert.NotNull(ticketServiceTest.GetTicket(1));
        }
    }
}
