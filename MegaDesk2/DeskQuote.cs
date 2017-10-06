using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        // constants
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;
        //const decimal RUSH_3DAY_LESS_THAN_1000 = 60.00M;
        //const decimal RUSH_3DAY_1000_TO_2000 = 70.00M;
        //const decimal RUSH_3DAY_GREATER_THAN_2000 = 80.00M;
        //const decimal RUSH_5DAY_LESS_THAN_1000 = 40.00M;
        //const decimal RUSH_5DAY_1000_TO_2000 = 50.00M;
        //const decimal RUSH_5DAY_GREATER_THAN_2000 = 60.00M;
        //const decimal RUSH_7DAY_LESS_THAN_1000 = 30.00M;
        //const decimal RUSH_7DAY_1000_TO_2000 = 35.00M;
        //const decimal RUSH_7DAY_GREATER_THAN_2000 = 40.00M;

        //enums
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        // properties
        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Delivery DeliveryType { get; set; }

        public decimal QuoteAmount { get; set; }

        // methods
        public decimal GetQuote()
        {
            //TODO:
            return 100.00M;
        }

        public void GetRushOrder()
        {
            //TODO:

        }
    }
}
