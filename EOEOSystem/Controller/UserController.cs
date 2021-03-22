using EOEOSystem.Model;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EOEOSystem.Controller
{
    public static class UserController
    {
        public static User GetUser(string login, string password)
        {
            string hashPass = GetHashSHA256(password);

            using (var db = new UnitDbContext())
            {
                return db.Users
                       .Where(u => u.Login.Equals(login) 
                                && u.Password.Equals(hashPass))
                       .FirstOrDefault<User>();
            }
        }

        public static RespondOperation AddUser(string login, string password, string name, string surname, Role role)
        {
            try
            {
                // TODO Dodać walidacje danych. Imię nie może przekroczyć maksymalnej wielkości w bazie.
                return TryAddUser(login, password, name, surname, role);
            }
            catch
            {
                return RespondOperation.Error;
            }
        }

        private static RespondOperation TryAddUser(string login, string password, string name, string surname, Role role)
        {
            using (var db = new UnitDbContext())
            {
                db.Users.Add(new User
                {
                    Login = login,
                    Password = GetHashSHA256(password),
                    Name = name,
                    Surname = surname,
                    RoleID = role
                });
                db.SaveChanges();
            }
            return RespondOperation.Ok;
        }

        private static string GetHashSHA256(string password)
        {
            using (var crypto = SHA256.Create())
            {
                byte[] bytesPass = Encoding.UTF8.GetBytes(password);
                byte[] hash = crypto.ComputeHash(bytesPass);
                var hashString = new StringBuilder();
                foreach (byte x in hash)
                {
                    hashString.Append(x.ToString("x2"));

                }
                return hashString.ToString();
            }
        }
    }
}
