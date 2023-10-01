using Aplicacao_de_vendas.Models;

namespace Aplicacao_de_vendas.Repositorys
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, Username = "edwin", Password = "teste", Role = "manager" },
                new User { Id = 2, Username = "leo", Password = "teste", Role = "employee" },
            };

            return users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == password);
              
        }

    }
}
