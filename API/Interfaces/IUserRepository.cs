using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
         void Update(AppUser user); // passing the AppUser object to do this;  is not an async method because all that's going to do is update the tracking status in entity framework
         Task<bool> SaveAllAsync(); // when we use a method we need to await it (because of ****Async)
         Task<IEnumerable<AppUser>> GetUsersAsync();
         Task<AppUser> GetUserByIdAsync (int id);
         Task<AppUser> GetUserByUsernameAsync (string username);
         Task<IEnumerable<MemberDto>> GetMembersAsync();
         Task<MemberDto> GetMemberAsync(string username);
    }
}