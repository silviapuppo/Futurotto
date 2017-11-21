using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise01
    {
        [TestMethod]
        public void TestMoveRobot()
        {
            RobotSimulator tester = new RobotSimulator();

            tester.MoveRobot("LAARAAAAARAAA");

            Assert.AreEqual(1, tester.Pos.X);
            Assert.AreEqual(5, tester.Pos.Y);
            Assert.AreEqual((int)Directions.East, tester.Dir);
        }

        [TestMethod]
        public void TestMoveRobotDiffOrigin()
        {
            RobotSimulator tester = new RobotSimulator(2,-1, (int)Directions.East);

            tester.MoveRobot("rRaArAl");

            Assert.AreEqual(0, tester.Pos.X);
            Assert.AreEqual(0, tester.Pos.Y);
            Assert.AreEqual((int)Directions.West, tester.Dir);
        }

        [TestMethod]
        public void TestMoveRobotDirRotation()
        {
            RobotSimulator tester = new RobotSimulator();

            tester.MoveRobot("RRRRLLLL");

            Assert.AreEqual(0, tester.Pos.X);
            Assert.AreEqual(0, tester.Pos.Y);
            Assert.AreEqual((int)Directions.North, tester.Dir);
        }

        [TestMethod]
        public void TestMoveRobotExample()
        {
            RobotSimulator tester = new RobotSimulator(7,3, (int)Directions.North);

            tester.MoveRobot("RAALAL");

            Assert.AreEqual(9, tester.Pos.X);
            Assert.AreEqual(4, tester.Pos.Y);
            Assert.AreEqual((int)Directions.West, tester.Dir);
        }


    }
}
