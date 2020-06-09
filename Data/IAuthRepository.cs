using EKnjiznica.Dtos;
using EKnjiznica.Models;

namespace EKnjiznica.Data
{
    public interface IAuthRepository
    {
        User CreateNewUser(UserForRegister user);
        bool ValidateUser(User user, string password);
        bool CheckUsername(string password);
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
    }
}