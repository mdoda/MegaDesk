using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Porter
{
    class DeskQuote
    {
        public DateTime QuoteDate { get; set; }

        public String CustomerName { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuote()
        {
            //200 is the starting amount for a desk
            decimal quote = 200;

            return 0;
        }
    }
}
