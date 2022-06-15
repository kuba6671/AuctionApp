using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.MVVM.Model
{
    static class Counter
    {
        private static int counterMainWindow = 0;
        private static int counterSearch = 0;

        public static void incrementMainWindow()
        {
            Counter.counterMainWindow = 1;
        }

        public static void incrementSearch()
        {
            Counter.counterSearch = 1;
        }

        public static int getCounterMainWindow()
        {
            return counterMainWindow;
        }

        public static int getCounterSearch()
        {
            return counterSearch;
        }
    }
}
