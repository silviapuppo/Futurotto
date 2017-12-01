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
            Assert.AreEqual(Directions.East, tester.Dir);
        }

        [TestMethod]
        public void TestMoveRobotDiffOrigin()
        {
            RobotSimulator tester = new RobotSimulator(new Point(2,-1), Directions.East);

            tester.MoveRobot("rRaArAl");

            Assert.AreEqual(0, tester.Pos.X);
            Assert.AreEqual(0, tester.Pos.Y);
            Assert.AreEqual(Directions.West, tester.Dir);
        }

        [TestMethod]
        public void TestMoveRobotDirRotation()
        {
            RobotSimulator tester = new RobotSimulator();

            tester.MoveRobot("RRRRLLLL");

            Assert.AreEqual(0, tester.Pos.X);
            Assert.AreEqual(0, tester.Pos.Y);
            Assert.AreEqual(Directions.North, tester.Dir);
        }

        [TestMethod]
        public void TestMoveRobotExample()
        {
            RobotSimulator tester = new RobotSimulator(new Point(7,3), Directions.North);

            tester.MoveRobot("RAALAL");

            Assert.AreEqual(9, tester.Pos.X);
            Assert.AreEqual(4, tester.Pos.Y);
            Assert.AreEqual(Directions.West, tester.Dir);
        }

        [TestMethod]
        public void TestMoveRobotNegative()
        {
            RobotSimulator tester = new RobotSimulator();

            tester.MoveRobot("LALA");

            Assert.AreEqual(-1, tester.Pos.X);
            Assert.AreEqual(-1, tester.Pos.Y);
            Assert.AreEqual(Directions.South, tester.Dir);
        }


    }
}
