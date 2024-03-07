using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Diagnostics;

namespace AntsV2.Test
{
    public class DeadAntsTest
    {
        [Fact]
        public void ComparePerformance()
        {
            string testString = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..an";

            var stopwatch = Stopwatch.StartNew();
            Program.DeadCounterAnts(testString);
            stopwatch.Stop();
            var timeForDeadCounterAnts = stopwatch.Elapsed.TotalMilliseconds;

            stopwatch.Restart();
            Program.DeadCounterAntsV2(testString);
            stopwatch.Stop();
            var timeForDeadCounterAntsV2 = stopwatch.Elapsed.TotalMilliseconds;

            Assert.True(timeForDeadCounterAntsV2 < timeForDeadCounterAnts);
        }

        [Fact]
        public void ShouldValidateAllAntsAlive()
        {
            Assert.Equal(0, Program.DeadCounterAntsV2("ant ant ant"));
        }

        [Fact]
        public void ShouldValidateAllAntsAreDead()
        {
            Assert.Equal(2, Program.DeadCounterAntsV2("atn n"));
        }

        [Fact]
        public void ShouldValidateMoreHeads()
        {
            Assert.Equal(4, Program.DeadCounterAnts("a a a a n t t t t"));
        }

        [Fact]
        public void ShouldValidateMoreTails()
        {
            Assert.Equal(5, Program.DeadCounterAntsV2("t t t t t a n"));
        }

        [Fact]
        public void ShouldValidateIfStringOrNull()
        {
            Assert.Equal(0, Program.DeadCounterAntsV2(""));
            Assert.Equal(0, Program.DeadCounterAntsV2(null));
        }
    }
}