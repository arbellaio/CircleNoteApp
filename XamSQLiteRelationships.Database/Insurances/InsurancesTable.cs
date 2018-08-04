using System;
using System.Threading.Tasks;
using XamSQLiteRelationships.Database.DatabaseHandler;
using XamSQLiteRelationships.Models.Insurances;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Database.Insurances
{
    public class InsurancesTable : IInsurancesTable
    {
        public LocalDatabase Handler { get; set; }

        public InsurancesTable(LocalDatabase _database)
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

        public async Task AddOrUpdateUserInsurance(Insurance insurance, int userId)
        {
            var user = await Handler.Database.Table<User>().Where(x => x.Id == userId).FirstOrDefaultAsync();
            var userInsurance = new Insurance
            {
                InsuranceType = insurance.InsuranceType,
                AppliedDate = insurance.AppliedDate,
                UserId = userId,
                User = user,
            };
            await Handler.Database.InsertOrReplaceAsync(userInsurance);
        }

        public async Task<Insurance> GetInsuranceByUserId(int userId)
        {
            var insurance = await Handler.Database.Table<Insurance>().Where(x => x.UserId == userId).FirstOrDefaultAsync();
            return insurance;
        }

        public async Task DeleteInsurance(int insuranceId)
        {
            var insurance = await Handler.Database.Table<Insurance>().Where(x => x.Id == insuranceId).FirstOrDefaultAsync();
            await Handler.Database.DeleteAsync(insurance);


        }
    }
}
