using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Module16.Tests
{
    [TestFixture]
    public class TicketServiceIntegrationTests
    {
        [Test]
        public void SaveTicketMustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test", 300);

            ticketServiceTest.SaveTicket(newTicket);

            var allTickets = ticketServiceTest.GetAllTickets();
            NUnit.Framework.Legacy.CollectionAssert.Contains(allTickets, newTicket);

            ticketServiceTest.DeleteTicket(newTicket);
            //var obj = new PrivateObject();

            var allTicketAfterDelete = ticketServiceTest.GetAllTickets();
            NUnit.Framework.Legacy.CollectionAssert.DoesNotContain(allTicketAfterDelete, newTicket);
        }
    }
}
