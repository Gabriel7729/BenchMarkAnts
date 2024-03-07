using AntsV2;
using BenchmarkDotNet.Attributes;
using System.Security.Cryptography;

namespace deadAntsPairProg
{
    public class BenchMarkAnts
    {
        string testString = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anan";

        [Benchmark]
        public void DeadCounterAnts() => Program.DeadCounterAnts(testString);

        [Benchmark]
        public void DeadCounterAntsV2() => Program.DeadCounterAntsV2(testString);
    }
}
