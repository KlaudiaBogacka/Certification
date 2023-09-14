namespace Certification
{
    internal class XiaomiMiRobotVacuumX10_ : IRobot
    {
        private List<float> grades = new List<float>();
        public XiaomiMiRobotVacuumX10_(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }
        public string Name { get; private set; }
        public string Model { get; private set; }

        public event RobotBase.GradeAddedDelegate GradeAdded;

        public void AddGrade(float grade)
        {
            int valueinInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;

                case "5":
                    this.grades.Add(80);
                    break;

                case "4":
                    this.grades.Add(60);
                    break;

                case "3":
                    this.grades.Add(40);
                    break;

                case "2":
                    this.grades.Add(20);
                    break;

                case "1":
                    this.grades.Add(10);
                    break;

                    throw new Exception("Do oceny możesz używać tylko liczb: 6, 5, 4, 3, 2, 1");
            }
        }

        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(char grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= this.grades.Count;

            return statistics;

        }
    }
}
