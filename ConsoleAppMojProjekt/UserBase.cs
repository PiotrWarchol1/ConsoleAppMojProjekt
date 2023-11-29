using System.Net.NetworkInformation;

namespace ConsoleAppMojProjekt
{
    public abstract class UserBase : IUser
    {
        public delegate void NumberAddedDelegate(object sender, EventArgs args);
        public abstract event NumberAddedDelegate NumberAdded;
        public UserBase(string name, string surname)                // Obsługa imienia i nazwiska
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }                            
        public string Surname { get; set; }

        public abstract void AddNumber(float punkt);                // Implementacja będzie w ostatniej klasie za 
        public abstract void AddNumber(int punkt);                  // pośrednictwem "abstract" w UserInMemory    
        public abstract void AddNumber(string punkt);               // Metoda abstract jest poniekąd pusta w porównaniu
        public abstract void AddNumber(char punkt);                 // do metody virtual gdzie ma swoje ciało
        public abstract Statistics GetStatistics();
    }
}
