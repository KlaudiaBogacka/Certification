namespace Certification
{
    public class Statistics
    {
        public float Min { get; set; }

        public float Max { get; set; }

        public float Average { get; set; }

        public float Sum { get; set; }
        public int Count { get; set; }

        public char AvetageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return '6';

                    case var average when average >= 60:
                        return '5';

                    case var average when average >= 40:
                        return '4';

                    case var average when average >= 20:
                        return '3';

                    default:
                        return '2';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }
    }
}
