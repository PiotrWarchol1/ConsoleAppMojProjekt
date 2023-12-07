using static ConsoleAppMojProjekt.UserBase;

namespace ConsoleAppMojProjekt
{
    public interface IUser
    {
        string Name { get; set; }
        string Surname { get; set; }
        
        void AddNumber(float punkt);
        void AddNumber(int punkt);
        void AddNumber(string punkt);
        void AddNumber(char punkt);
        event NumberAddedDelegate NumberAdded;
        Statistics GetStatistics();
    }
}
