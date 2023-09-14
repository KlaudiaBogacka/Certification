namespace Certification
{
    public class RobotInMemory : RobotBase
    {
        public event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public RobotInMemory (string name, string model)
            : base (name, model)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
               
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("string is not float");
            }
        }

        public override void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case '6':
                    this.grades.Add(100);
                    break;

                case '5':
                    this.grades.Add(80);
                    break;

                case '4':
                    this.grades.Add(60);
                    break;

                case '3':
                    this.grades.Add(40);
                    break;

                case '2':
                    this.grades.Add(20);
                    break;

                case '1':
                    this.grades.Add(10);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;

        }
    }
}
