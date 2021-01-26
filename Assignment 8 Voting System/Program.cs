using System;

namespace Assignment_8_Voting_System
{
    class Program
    {

        private static int i = 0;

        static void Main(string[] args)
        {
            Vote[] votes = new Vote[100];

            CastVote(votes);
        }

        static void CastVote(Vote[] votes)
        {

            bool finished = false;
            while (finished == false)
            {
                Console.WriteLine("What is your name?");
                string votername = Console.ReadLine();
                Console.WriteLine("Submit 1 for democrats, 2 for communists, 3 for facists, press any other number for EXIT");
                int partynumber = Console.Read();


                if (partynumber == 1)
                {
                    votes[i] = new Vote(votername, "Democrats");
                }
                else if (partynumber == 2)
                {
                    votes[i] = new Vote(votername, "Communists");
                }
                else if (partynumber == 3)
                {
                    votes[i] = new Vote(votername, "Facists");
                }
                else
                {
                    finished = true;
                }
            }


        }
    }
}
