using static Certification.RobotBase;

namespace Certification
{
    public interface IRobot
    {
        string Name { get; }

        string Model { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(long grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        Statistics GetStatistics();
    }
}
