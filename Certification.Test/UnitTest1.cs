namespace Certification.Test
{
    public class RobotTests
    {
        [Test]
        public void WhenICalledStatisticsMaxValueTest()
        {
            var robot = new Robot("BekoRobot", "Smart");
            robot.AddGrade(6);
            robot.AddGrade(1);
            robot.AddGrade(3);
            robot.AddGrade(4);
            robot.AddGrade(2);

            var statistics = robot.GetStatistics();

            Assert.AreEqual(6, statistics.Max);

        }

        [Test]
        public void WhenICalledStatisticsMinValueTest()
        {
            var robot = new Robot("BekoRobot", "Smart");
            robot.AddGrade(6);
            robot.AddGrade(1);
            robot.AddGrade(3);
            robot.AddGrade(4);
            robot.AddGrade(2);

            var statistics = robot.GetStatistics();

            Assert.AreEqual(1, statistics.Min);
        }

        [Test]
        public void WhenICalledStatisticsAverageValue()
        {
            var robot = new Robot("BekoRobot", "Smart");
            robot.AddGrade(6);
            robot.AddGrade(1);
            robot.AddGrade(3);
            robot.AddGrade(4);
            robot.AddGrade(2);

            var statistics = robot.GetStatistics();

            Assert.AreNotEqual(4, statistics.Average);
        }
    }
}