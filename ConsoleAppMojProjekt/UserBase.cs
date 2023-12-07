namespace ConsoleAppMojProjekt 
{
    public abstract class UserBase : IUser
    {
        public delegate void NumberAddedDelegate(object sender, EventArgs args);
        public abstract event NumberAddedDelegate NumberAdded;
        public UserBase(string name, string surname)                
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }                            
        public string Surname { get; set; }

        public abstract void AddNumber(float punkt);                
        public abstract void AddNumber(int punkt);                      
        public abstract void AddNumber(string punkt);               
        public abstract void AddNumber(char punkt);                 
        public abstract Statistics GetStatistics();
    }
}
