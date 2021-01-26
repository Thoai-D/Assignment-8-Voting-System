using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Voting_System
{
    class Vote
    {
        private string votername;
        private string partyname; //democrats, facists, communists
        private DateTime timevoted;

        private static double totalvotes = 0;

        //constructor
        public Vote(string votername, string partyname)
        {
            DateTime currenttime = DateTime.Now;

            this.votername = votername;
            this.partyname = partyname;

            timevoted = currenttime;
            totalvotes = totalvotes + 1;
        }


        //accessor
        public string Getpartyvotedfor()
        {
            return partyname;
        }

        public DateTime Gettimevoted()
        {
            return timevoted;
        }


        public static double Gettotalvotes()
        {
            return totalvotes;
        }



    }
}
