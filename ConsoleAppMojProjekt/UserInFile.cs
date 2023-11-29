using System.Diagnostics;

namespace ConsoleAppMojProjekt
{
    public class UserInFile : UserBase                      
    {
        public override event NumberAddedDelegate NumberAdded;

        private List<float> numbers = new List<float>();    

        private const string fileNumber = "number.txt";     
        public UserInFile(string name, string surname)      
            : base(name, surname)
        {
        }

        public override void AddNumber(float number)
        {
            using (var writer = File.CreateText(fileNumber))
            {
                writer.WriteLine(number);
            }
            if (NumberAdded != null)
            {
                NumberAdded(this, new EventArgs());
            }
        }

        public override void AddNumber(int number)
        {
            float numbwerAsFloat = (float)number;
            this.AddNumber(numbwerAsFloat);
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

        public override void AddNumber(char number)
        {
            using (var writer = File.AppendText(fileNumber))
            {
                writer.WriteLine(number);
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
