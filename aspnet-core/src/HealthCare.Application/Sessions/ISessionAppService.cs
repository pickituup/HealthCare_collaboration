using System.Threading.Tasks;
using Abp.Application.Services;
using HealthCare.Sessions.Dto;

namespace HealthCare.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
