using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadAntsTestxUnit
{
    public class Program
    {
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
                if (ants[i] == 'a') heads++;
                else if (ants[i] == 'n') bodies++;
                else if (ants[i] == 't') tails++;

                if (i >= 2 && ants[i - 2] == 'a' && ants[i - 1] == 'n' && ants[i] == 't')
                {
                    heads--;
                    bodies--;
                    tails--;
                    continue;
                }

                //if (ants[i] == 'a') heads++;
                //else if (ants[i] == 'n') bodies++;
                //else if (ants[i] == 't') tails++;
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
