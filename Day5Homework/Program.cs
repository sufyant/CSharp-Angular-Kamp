namespace Day5Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            
            gamerManager.Add(new Gamer
            {
                FirstName = "Sufyan",
                LastName = "Taskin",
                IdentityNumber = 11,
                YearOfBirth = 1996
            });
            
            
        }
    }
}