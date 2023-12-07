namespace ConsoleAppMojProjekt
{

    public class UserInMemmory: UserBase                           
    {
        public override event NumberAddedDelegate NumberAdded;

        public delegate void WriteMessage(string message);

        private List<float> numbers = new List<float>();

        public UserInMemmory(string name, string surname)
           : base(name, surname)
        {
        }
        public override void AddNumber(float number)
        {
            if(number >= 0 &&  number <= 100)
            {
                this.numbers.Add(number);
                if (NumberAdded != null)
                {
                    NumberAdded(this, new EventArgs());
                }
            }
            else
            { 
                throw new Exception("Niewłaściwa liczba");
            }
        }
        public override void AddNumber(int number)
        {
            float result = number;
            this.AddNumber((float)number);
        }
        public override void AddNumber(string number)
        {
            if (float.TryParse(number, out float result))
            {
                this.AddNumber(result);
            }
            else
            {
                throw new Exception("Wartość nie jest liczbą");
            }
        }
        public override void AddNumber(char number)
        {
            switch (number)
            {
                case 'A':
                    this.numbers.Add(100);
                    break;
                case 'B':
                    this.numbers.Add(80);
                    break;
                case 'C':
                    this.numbers.Add(60);
                    break;
                case 'D':
                    this.numbers.Add(40);
                    break;
                case 'E':
                    this.numbers.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();                              

            foreach (var number in this.numbers)
            {
                statistics.AddNumber(number);
            }
            return statistics;                                             
        }
    }
}
