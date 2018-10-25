using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_JalynZamora
{
    public class DeskQuote
    {
        public int DeskQuoteId { get; set; }
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { set; get; }
        public int Shipping { get; set; }
        public int Price { get; set; }

        public decimal GetQuote()
        {

            //TODO: calculate quote amount
            return 0;
        }
    }
}
