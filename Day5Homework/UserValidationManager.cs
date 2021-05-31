namespace Day5Homework
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Sufyan" &&
                gamer.LastName == "Taskin"  &&
                gamer.YearOfBirth == 1996   &&
                gamer.IdentityNumber == 11
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}