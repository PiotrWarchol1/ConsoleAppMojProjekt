
namespace ConsoleAppMojProjekt
{
    public class Statistics
    { 
        public float Max { get;  set; }
        public float Min { get;  set; }
        public float Sum { get;  set; }
        public int Count { get;  set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
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

        public void AddNumber(float number)
        {
            this.Count++;
            this.Sum += number;
            this.Min = Math.Min(this.Min, number);
            this.Max = Math.Max(this.Max, number);
        }
    }
}

