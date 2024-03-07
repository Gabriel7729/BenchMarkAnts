using System;
using System.Linq;

namespace AntsV2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string antsTrial = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

            int deadAnts = DeadCounterAntsV2(antsTrial);
            Console.WriteLine("Dead ants: " + deadAnts);
        }

        public static int DeadCounterAntsV2(string ants)
        {
            if (string.IsNullOrEmpty(ants))
                return 0;

            int heads = 0;
            int bodies = 0;
            int tails = 0;
            int deadAnts;

            for (int i = 0; i < ants.Length; i++)
            {
                if (ants[i] == 'a' && ants[i + 1] == 'n' && ants[i + 2] == 't')
                {
                    i += 2;
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

        public static int DeadCounterAnts(string antsTrial)
        {
            if (string.IsNullOrEmpty(antsTrial))
                return 0;

            string replaceAnts = antsTrial.Replace("ant", string.Empty);

            int aCount = replaceAnts.Count(x => x == 'a');
            int nCount = replaceAnts.Count(x => x == 'n');
            int tCount = replaceAnts.Count(x => x == 't');

            return Math.Max(aCount, Math.Max(nCount, tCount));
        }
    }
}