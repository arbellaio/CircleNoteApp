using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Insurances;

namespace XamSQLiteRelationships.Modules.Insurances
{
    public class InsurancesModule : IInsurancesModule
    {
        public async Task AddOrUpdateUserInsurance(Insurance insurance, int userId)
        {
            await App.Database.Insurances.AddOrUpdateUserInsurance(insurance, userId);
        }

        public async Task<Insurance> GetInsuranceByUserId(int userId)
        {
           var insurance = await App.Database.Insurances.GetInsuranceByUserId(userId);
           return insurance;
        }

        public async Task DeleteInsurance(int insuranceId)
        {
            await App.Database.Insurances.DeleteInsurance(insuranceId);
        }
    }
}