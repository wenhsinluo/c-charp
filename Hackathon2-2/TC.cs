using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2_2
{
    public class TC
    {
        public string TCname { get; set; }

        public int Monthly_fee { get; set; }

        public int Minute_fee { get; set; }

        public int Total { get; set; }


        public static void BestPrices( TC tc ,int input)
        {
            tc.Total = tc.Monthly_fee + (tc.Minute_fee * input);
        }

    }

}
