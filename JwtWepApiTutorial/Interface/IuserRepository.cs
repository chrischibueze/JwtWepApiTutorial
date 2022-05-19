using JwtWepApiTutorial.Dto;
using JwtWepApiTutorial.Model;

namespace JwtWepApiTutorial.Interface
{
    public interface IuserRepository
    {
        public Task<user> Register(UserDto user);
    }
}
