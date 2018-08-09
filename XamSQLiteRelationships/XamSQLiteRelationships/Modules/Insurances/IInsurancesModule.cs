using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Insurances;

namespace XamSQLiteRelationships.Modules.Insurances
{
    public interface IInsurancesModule
    {
        Task AddOrUpdateUserInsurance(Insurance insurance, int userId);
        Task<Insurance> GetInsuranceByUserId(int userId);
        Task DeleteInsurance(int insuranceId);
    }
}
