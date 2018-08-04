using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Modules.Users
{
    public interface IUsersModule
    {
        int LoggedInUserId { get; set; }

        Task AddOrUpdateUser(User user);
        Task<bool> LoginUser(string email, string password);
        Task<List<User>> GetAllUsers();

        Task<User> GetUserByEmail(string email);

        Task<User> GetUserById(int userId);
    }
}
