using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Database.DatabaseHandler;
using XamSQLiteRelationships.Models.Events;
using XamSQLiteRelationships.Models.Insurances;
using XamSQLiteRelationships.Models.Users;
using XamSQLiteRelationships.Models.UsersEvents;

namespace XamSQLiteRelationships.Database.Users
{
    public class UsersTable : IUsersTable
    {
        public LocalDatabase Handler { get; set; }

        public UsersTable(LocalDatabase _database)
        {
            if (_database == null)
            {
                throw new ArgumentNullException("Database");
            }
            else
            {
                Handler = _database;
            }                        
        }


        public async Task AddOrUpdateUser(User user)
        {
            await Handler.Database.InsertAsync(user);
        }

        public async Task<int> LoginUser(string email, string password)
        {
            var user = await Handler.Database.Table<User>().Where(x => x.Email.ToLower().Equals(email) && x.Password.ToLower().Equals(password)).FirstOrDefaultAsync();

            if (user == null)           
                return 0;

            return user.Id;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await Handler.Database.Table<User>().ToListAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await Handler.Database.Table<User>().Where(x => x.Email.ToLower().Equals(email)).FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetUserById(int userId)
        {
            var user = await Handler.Database.Table<User>().Where(x => x.Id == userId).FirstOrDefaultAsync();
            return user;
        }
    }
}
