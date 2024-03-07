//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace deadAntsPairProg.TestFramewoek
//{
//    [TestClass]
//    public class DeadAnts
//    {
//        [TestMethod]
//        public void ShouldValidateAllAntsAlive()
//        {
//            Assert.AreEqual(0, Program.DeadCounterAnts("ant ant ant"));
//        }

//        [TestMethod]
//        public void ShouldValidateAllAntsAreDead()
//        {
//            Assert.AreEqual(2, Program.DeadCounterAnts("atn n"));
//        }

//        [TestMethod]
//        public void ShouldValidateMoreHeads()
//        {
//            Assert.AreEqual(4, Program.DeadCounterAnts("a a a a n t t t t"));
//        }

//        [TestMethod]
//        public void ShouldValidateMoreTails()
//        {
//            Assert.AreEqual(5, Program.DeadCounterAnts("t t t t t a n"));
//        }

//        [TestMethod]
//        public void ShouldValidateIfStringOrNull()
//        {
//            Assert.AreEqual(0, Program.DeadCounterAnts(""));
//            Assert.AreEqual(0, Program.DeadCounterAnts(null));
//        }
//    }
//}
