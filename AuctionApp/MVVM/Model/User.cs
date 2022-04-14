using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.MVVM.Model
{
    static class User
    {
        private static int userID;
        private static string username;

        public static string getUsername()
        {
            return username;
        }

        public static int getUserID()
        {
            return userID;
        }

        public static void SetUsername(string username) => User.username = username;
        public static void SetUserID(int userID) => User.userID = userID;

    }
}
