using System.Threading.Tasks;
using Abp.Application.Services;
using HealthCare.Authorization.Accounts.Dto;

namespace HealthCare.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
