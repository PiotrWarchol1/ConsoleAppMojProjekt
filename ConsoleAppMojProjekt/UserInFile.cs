namespace ConsoleAppMojProjekt
{
    public class UserInFile : UserBase                      
    {
        private const string fileNumber = "number.txt";  
        
        public override event NumberAddedDelegate NumberAdded;

        public UserInFile(string name, string surname)      
            : base(name, surname)
        {
        }

        public override void AddNumber(float number)
        {
            if (number >= 0 && number <= 100)
            {
                using (var writer = File.AppendText(fileNumber))
                {
                    writer.WriteLine(number);
                }
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
            float numberAsFloat = (float)number;
            this.AddNumber(numberAsFloat);
        }
        public override void AddNumber(char number)
        {
            float numberAsFloat = (float)number;
            this.AddNumber(numberAsFloat);
        }
        public override void AddNumber(string number)
        {
            if (float.TryParse(number, out float result))
            {
                this.AddNumber(result);
            }
            else
            {
                throw new Exception("Nie właściwa wartość");
            }
            
        }
        public override Statistics GetStatistics()
        {
            var numbersFromFile = this.ReadNumbersFromFile();
            var result = this.CountStatistics(numbersFromFile);
            return result;
        }


        private List<float> ReadNumbersFromFile()
        {
            var numbers = new List<float>();
            if (File.Exists($"{fileNumber}"))
            {
                using (var reader = File.OpenText($"{fileNumber}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        numbers.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return numbers;
        }
        private Statistics CountStatistics(List<float> numbers)
        {
            var statistics = new Statistics();                              

            foreach (var number in numbers)
            {
                statistics.AddNumber(number);
            }
            return statistics;                                              
        }
    }
}
