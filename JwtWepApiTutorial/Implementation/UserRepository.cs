using JwtWepApiTutorial.Dto;
using JwtWepApiTutorial.Interface;
using JwtWepApiTutorial.Model;
using System.Security.Cryptography;

namespace JwtWepApiTutorial.Implementation
{
    public class UserRepository : IuserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        }
        public Task<user> Register(UserDto request)
        {
            
        }
    }
}
