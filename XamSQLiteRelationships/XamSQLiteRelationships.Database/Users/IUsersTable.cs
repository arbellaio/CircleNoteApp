using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Events;
using XamSQLiteRelationships.Models.Insurances;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Database.Users
{
    public interface IUsersTable
    {
        Task AddOrUpdateUser(User user);
        Task<int> LoginUser(string email, string password);
        Task<List<User>> GetAllUsers();
     
        Task<User> GetUserByEmail(string email);
      
        Task<User> GetUserById(int userId);
    }
}
