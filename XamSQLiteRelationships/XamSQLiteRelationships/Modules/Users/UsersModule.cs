using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Modules.Users
{
    public class UsersModule : IUsersModule
    {
        private int loggedInUserId;

        public int LoggedInUserId
        {
            get { return loggedInUserId; }
            set { loggedInUserId = value; }
        }


        public async Task AddOrUpdateUser(User user)
        {
          await App.Database.Users.AddOrUpdateUser(user);
        }

        public async Task<bool> LoginUser(string email, string password)
        {
           var userId =  await App.Database.Users.LoginUser(email, password);
            if (userId != 0)
            {
                LoggedInUserId = userId;
                return true;
            }
            return false;
        }

        public async Task<List<User>> GetAllUsers()
        {
           var userslist = await App.Database.Users.GetAllUsers();
           return userslist;
        }

        public Task<User> GetUserByEmail(string email)
        {
            var user = App.Database.Users.GetUserByEmail(email);
            return user;
        }

        public Task<User> GetUserById(int userId)
        {
            var user = App.Database.Users.GetUserById(userId);
            return user;
        }
    }
}