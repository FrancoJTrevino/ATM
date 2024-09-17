using ATM.Data;
using ATM.Models;
using System.Configuration;
using System.Security.Cryptography;

namespace ATM
{
    public class Logic
    {
        private const int SaltSize = 128 / 8;
        private const int KeySize = 256 / 8;
        private const int Iterations = 10000;
        private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA256;
        private const char Delimiter = ';';
        ATMContext context = new ATMContext();

        public Account GetAccount(int userID)
        {
            var account = new Account();
            account = context.Accounts.Where(x => x.UserID == userID).FirstOrDefault();
            if (account != null) return account;
            return new Account();
        }

        public List<Account> GetAccounts(int userID)
        {
            var account = new List<Account>();
            account = context.Accounts.Where(x => x.UserID == userID).ToList();
            if (account != null) return account;
            return new List<Account>();
        }

        public User GetUser(string username, string password)
        {
            var user = new User();
            user = context.Users.Where(x => x.Username == username).FirstOrDefault();
            if (user != null && Verify(user.Password, password)) return user;
            return new User();
        }

        public User GetUser(int userID)
        {
            var user = context.Users.Where(x => x.ID == userID).FirstOrDefault();
            if (user != null) return user;
            return new User();
        }
        public bool UserExists(string username)
        {
            var user = context.Users.Where(x => x.Username == username).FirstOrDefault();
            if (user != null) return true;
            return false;
        }

        public bool AddUser(User user)
        {
            context.Users.Add(user);
            if (context.SaveChanges() > 0) return true;
            return false;
        }

        public bool AddAccount(Account acc)
        {
            context.Accounts.Add(acc);
            if (context.SaveChanges() >0) return true;
            return false;
        }

        public bool DeleteUser(int userID)
        {
            var result = context.Users.SingleOrDefault(x => x.ID == userID);
            if (result != null)
            {
                context.Users.Remove(result);
                if (context.SaveChanges() > 0) return true;
            }
            return false;
        }

        public bool DeleteAccount(int accID)
        {
            var result = context.Accounts.SingleOrDefault(x => x.ID == accID);
            if (result != null)
            {
                context.Accounts.Remove(result);
                if (context.SaveChanges() > 0) return true;
            }
            return false;
        }

        public bool UpdateAccount(Account acc)
        {
            var result = context.Accounts.SingleOrDefault(x => x.ID == acc.ID);
            if (result != null)
            {
                result = acc;
                if (context.SaveChanges() > 0) return true;
            }
            return false;
        }

        public bool UpdateUser(User user)
        {
            var result = context.Users.SingleOrDefault(x => x.ID == user.ID);
            if (result != null)
            {
                result = user;
                if (context.SaveChanges() > 0) return true;
            }
            return false;
        }

        public string Hash(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, _hashAlgorithmName, KeySize);

            return string.Join(Delimiter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public bool Verify(string passwordHash, string inputPassword)
        {
            var elements = passwordHash.Split(Delimiter);
            var salt = Convert.FromBase64String(elements[0]);
            var hash = Convert.FromBase64String(elements[1]);

            var hashInput = Rfc2898DeriveBytes.Pbkdf2(inputPassword, salt, Iterations, _hashAlgorithmName, KeySize);

            return CryptographicOperations.FixedTimeEquals(hash, hashInput);
        }
    }
}
