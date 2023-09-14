namespace Certification
{
    public abstract class RobotBase : IRobot
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;
        public RobotBase(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }
        public string Model { get; private set; }
        public string Name { get; private set; }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);


        public abstract Statistics GetStatistics();
    }
}
