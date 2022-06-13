using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.MVVM.Model
{
    static class Counter
    {
        private static int counter = 0;

        public static void increment()
        {
            Counter.counter = 1;
        }

        public static int getCounter()
        {
            return counter;
        }
    }
}
