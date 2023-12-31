using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16
{
    public class TicketPrice
    {
        ITicketService _ticketService;

        public TicketPrice(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public int MakeTicketPrice(int ticketId) 
        {
            return _ticketService.GetTicketPrice(ticketId);
        }
    }
}
