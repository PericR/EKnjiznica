using System;
using System.Linq;
using EKnjiznica.Data;
using EKnjiznica.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EKnjiznica.Models
{
    public class SeedData
    {


        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (!context.Users.Any())
                {
                    byte[] passwordHash, passwordSalt;
                    using (var hmac = new System.Security.Cryptography.HMACSHA512())
                    {
                        passwordSalt = hmac.Key;
                        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("12345678"));
                    }

                    User firstAdmin = new User
                    {
                        FirstName = "Admin",
                        LastName = "Admin",
                        Username = "Admin",
                        Email = "admin@gmail.com",
                        AccountBalance = 1000,
                        IsAdmin = true,
                        PasswordHash = passwordHash,
                        PasswordSalt = passwordSalt
                    };

                    context.Users.Add(firstAdmin);
                    context.SaveChanges();
                }
            }
        }
    }
}