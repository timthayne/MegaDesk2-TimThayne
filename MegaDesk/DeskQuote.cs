using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        // properties
        public Desk Desk { get; set; }

        public int RushDays { get; set; }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }


        // methods
        decimal GetQuote()
        {
            //TODO:
            return 0;
        }
    }
}
