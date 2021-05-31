using System;

namespace Day5Homework
{
    public class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayit oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama yapilamadi");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit guncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi");
        }
    }
}