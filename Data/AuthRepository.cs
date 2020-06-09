using System.Linq;
using EKnjiznica.Dtos;
using EKnjiznica.Models;
using Microsoft.AspNetCore.Http;

namespace EKnjiznica.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;

        }
        public User CreateNewUser(UserForRegister userForRegister)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(userForRegister.Password, out passwordHash, out passwordSalt);

            User newUser = new User();
            newUser.Username = userForRegister.Username;
            newUser.FirstName = userForRegister.FirstName;
            newUser.LastName = userForRegister.LastName;
            newUser.AccountBalance = 0;
            newUser.IsAdmin = false;
            newUser.PasswordHash = passwordHash;
            newUser.PasswordSalt = passwordSalt;
            newUser.Email = userForRegister.Email;

            return newUser;
        }

        public bool ValidateUser(User user, string password)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(user.PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != user.PasswordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool CheckUsername(string username)
        {
            User existing = _context.Users.FirstOrDefault(u => u.Username == username);

            if(existing != null)
            {
                return true;
            }
            
            return false;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}