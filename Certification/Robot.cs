using System.ComponentModel.Design;

namespace Certification
{
    public class Robot : IRobot
    {
        private List<float> grades = new List<float>();

        public Robot(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }
        public string Name { get; private set; }

        public string Model { get; private set; }

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
           if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("string is not float");
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
            switch(grade)
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
                    this.grades.Add(5);
                    break;

                default:
                    throw new Exception("Wrong grade");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                if(grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= this.grades.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.Average = '6';
                    break;

                case var average when average >= 60:
                    statistics.Average = '5';
                    break;

                case var average when average >= 40:
                    statistics.Average = '4';
                    break;

                case var average when average >= 20:
                    statistics.Average = '3';
                    break;

                case var average when average >= 10:
                    statistics.Average = '2';
                    break;

                default:
                    statistics.Average = '1';
                    break;
            }
            return statistics;
        }
    }
}
