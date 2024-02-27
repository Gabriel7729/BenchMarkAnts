using System;

namespace deadAntsPairProg
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string antChain = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
            int deadAnts = DeadCounterAnts(antChain);
            Console.WriteLine("The amount of dead ants is: " + deadAnts);
        }

        public static int DeadCounterAnts(string ants)
        {
            if (string.IsNullOrEmpty(ants))
                return 0;
            
            int heads = 0;
            int bodies = 0;
            int tails = 0;
            int deadAnts = 0;

            for (int i = 0; i < ants.Length; i++)
            {
                if (ants[i] == 'a' && ants[i+1] == 'n' && ants[i+2] == 't')
                {
                    i = i + 2;
                    continue;
                }

                if (ants[i] == 'a') heads++;
                else if (ants[i] == 'n') bodies++;
                else if (ants[i] == 't') tails++;
            }

            deadAnts = Math.Max(heads, bodies);
            deadAnts = Math.Max(deadAnts, tails);

            return deadAnts;
        }
    }
}
